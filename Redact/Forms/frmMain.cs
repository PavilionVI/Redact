using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Redact
{
    public partial class frmMain : Form
    {
        private Point _startPoint;
        private Rectangle _startRect;
        private readonly SolidBrush _blackoutBrush;

        private readonly ToolStripButton[] _optionTSB;

        public frmMain()
        {
            InitializeComponent();

            _blackoutBrush = new SolidBrush(Color.Black);
            _optionTSB = new ToolStripButton[] { tsbBlock, tsbPixel };

            foreach (var tsb in _optionTSB)
                tsb.Click += tsb_Click;

            this.Resize += new EventHandler(form_Displace);
            this.Move += new EventHandler(form_Displace);
        }

        public void tsb_Click(object sender, EventArgs e)
        {
            _startRect = Rectangle.Empty;
            var tsbSent = (ToolStripButton)sender;

            foreach (var tsb in _optionTSB)
                tsb.Checked = tsb == tsbSent;

            var regionPoint = PointToScreen(pbMain.Location);
            var regionShot = new Bitmap(pbMain.Width, (pbMain.Height - tsBottom.Height), System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (var g = Graphics.FromImage(regionShot))
                g.CopyFromScreen(regionPoint.X, regionPoint.Y, 0, 0, pbMain.Size, CopyPixelOperation.SourceCopy);

            pbMain.Image = regionShot;
            pbMain.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        public void form_Displace(object sender, EventArgs e)
        {
            pbMain.BackColor = Color.Fuchsia;
            pbMain.Image = null;

            _startRect = Rectangle.Empty;

            foreach (var tsb in _optionTSB)
                tsb.Checked = false;

            tsbUpload.Enabled = false;
            tsbSave.Enabled = false;
        }

        private void pbMain_MouseDown(object sender, MouseEventArgs e)
        {
            _startPoint = e.Location;
            pbMain.Invalidate();
        }

        private void pbMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            var tempPoint = e.Location;

            _startRect.Location = new Point(Math.Min(_startPoint.X, tempPoint.X), Math.Min(_startPoint.Y, tempPoint.Y));
            _startRect.Size = new Size(Math.Abs(_startPoint.X - tempPoint.X), Math.Abs(_startPoint.Y - tempPoint.Y));

            if (tsbPixel.Checked)
                pbMain.Image = Pixelator.Pixelate(new Bitmap(pbMain.Image), _startRect);

            pbMain.Invalidate();
        }

        private void pbMain_MouseUp(object sender, MouseEventArgs e)
        {
            tsbUpload.Enabled = true;
            tsbSave.Enabled = true;
        }

        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            if (tsbBlock.Checked && _startRect.Width > 0 && _startRect.Height > 0)
                e.Graphics.FillRectangle(_blackoutBrush, _startRect);
        }

        private async void tsbUpload_Click(object sender, EventArgs e)
        {
            pbUpload.Visible = true;
            var url = await Exporter.ToImgur(pbMain.Image);

            pbUpload.Visible = false;

            if (url != null)
            {
                Clipboard.SetText(url);

                MessageBox.Show("Uploaded successfully. The URL has been copied to your clipboard.", "Redact", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Upload failed.", "Redact", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Exporter.SaveImage(pbMain.Image);
        }
    }
}
