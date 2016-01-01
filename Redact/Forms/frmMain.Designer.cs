namespace Redact
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tsBottom = new System.Windows.Forms.ToolStrip();
            this.tsbPixel = new System.Windows.Forms.ToolStripButton();
            this.tsbBlock = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbUpload = new System.Windows.Forms.ToolStripButton();
            this.tslURL = new System.Windows.Forms.ToolStripLabel();
            this.pbUpload = new System.Windows.Forms.ToolStripProgressBar();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.tsBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tsBottom
            // 
            this.tsBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPixel,
            this.tsbBlock,
            this.tsbSave,
            this.tsbUpload,
            this.tslURL,
            this.pbUpload});
            this.tsBottom.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsBottom.Location = new System.Drawing.Point(0, 227);
            this.tsBottom.Name = "tsBottom";
            this.tsBottom.Padding = new System.Windows.Forms.Padding(0);
            this.tsBottom.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsBottom.Size = new System.Drawing.Size(494, 25);
            this.tsBottom.TabIndex = 3;
            // 
            // tsbPixel
            // 
            this.tsbPixel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPixel.Image = ((System.Drawing.Image)(resources.GetObject("tsbPixel.Image")));
            this.tsbPixel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPixel.Name = "tsbPixel";
            this.tsbPixel.Size = new System.Drawing.Size(51, 22);
            this.tsbPixel.Text = "Pixelate";
            // 
            // tsbBlock
            // 
            this.tsbBlock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBlock.Image = ((System.Drawing.Image)(resources.GetObject("tsbBlock.Image")));
            this.tsbBlock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBlock.Name = "tsbBlock";
            this.tsbBlock.Size = new System.Drawing.Size(40, 22);
            this.tsbBlock.Text = "Block";
            // 
            // tsbSave
            // 
            this.tsbSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.Enabled = false;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(35, 22);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbUpload
            // 
            this.tsbUpload.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbUpload.Enabled = false;
            this.tsbUpload.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpload.Image")));
            this.tsbUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpload.Name = "tsbUpload";
            this.tsbUpload.Size = new System.Drawing.Size(49, 22);
            this.tsbUpload.Text = "Upload";
            this.tsbUpload.Click += new System.EventHandler(this.tsbUpload_Click);
            // 
            // tslURL
            // 
            this.tslURL.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslURL.IsLink = true;
            this.tslURL.Name = "tslURL";
            this.tslURL.Size = new System.Drawing.Size(0, 22);
            this.tslURL.Visible = false;
            // 
            // pbUpload
            // 
            this.pbUpload.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pbUpload.MarqueeAnimationSpeed = 120;
            this.pbUpload.Name = "pbUpload";
            this.pbUpload.Size = new System.Drawing.Size(140, 22);
            this.pbUpload.Step = 40;
            this.pbUpload.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbUpload.Visible = false;
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.Color.Fuchsia;
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMain.Location = new System.Drawing.Point(0, 0);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(494, 252);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMain.TabIndex = 2;
            this.pbMain.TabStop = false;
            this.pbMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMain_Paint);
            this.pbMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseDown);
            this.pbMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseMove);
            this.pbMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseUp);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 252);
            this.Controls.Add(this.tsBottom);
            this.Controls.Add(this.pbMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redact";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.tsBottom.ResumeLayout(false);
            this.tsBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip tsBottom;
        internal System.Windows.Forms.ToolStripButton tsbPixel;
        internal System.Windows.Forms.ToolStripButton tsbBlock;
        internal System.Windows.Forms.ToolStripButton tsbSave;
        internal System.Windows.Forms.ToolStripButton tsbUpload;
        internal System.Windows.Forms.ToolStripLabel tslURL;
        internal System.Windows.Forms.ToolStripProgressBar pbUpload;
        internal System.Windows.Forms.PictureBox pbMain;
    }
}

