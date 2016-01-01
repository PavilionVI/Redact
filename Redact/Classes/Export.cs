using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

public static class Exporter
{
    public async static Task<string> ToImgur(Image img)
    {
        var uploader = new ImgurUploader(img);

        return await uploader.UploadAsync();
    }
    
    public static void SaveImage(Image img)
    {
        try
        {
            using (var sfd = new SaveFileDialog { Title = "Redact | Save Image", Filter = "PNG Files (.png) | *.png" })
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    img.Save(sfd.FileName, ImageFormat.Png);

                    MessageBox.Show("Image successfully saved to " + sfd.FileName, "Redact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
        catch
        {
            MessageBox.Show("An error occured when attempting to save.", "Redact", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}