using System;
using System.Net.Http;
using System.Drawing;
using System.Net;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.IO;
using System.Text;
using System.Collections.Specialized;
using System.Xml.Linq;

public class ImgurUploader
{
    private string _imgBase;

    public ImgurUploader(Image img)
    {
        _imgBase = ImageToBase64(img);
    }
    
    public async Task<string> UploadAsync()
    {
        using (var wc = new WebClient())
        {
            wc.Headers.Add("Authorization", "Client-ID 8edc85d3fc5010d");

            var content = new NameValueCollection()
            {
                {"image", _imgBase }
            };

            var response = await wc.UploadValuesTaskAsync("https://api.imgur.com/3/upload.json", content);
            var imgData = JsonUtil.Deserialize<ImgurResponse>(Encoding.Default.GetString(response));

            if (imgData.success)
                return imgData.data.link;
            else
                return null;
        }
    }

    private string ImageToBase64(Image img)
    {
        var imgConv = new ImageConverter();
        var buffer = (byte[])imgConv.ConvertTo(img, typeof(byte[]));

        return Convert.ToBase64String(buffer, Base64FormattingOptions.None);
    }
}