using System;
using System.Drawing;

public class Pixelator
{
    public static Bitmap Pixelate(Bitmap bmp, Rectangle area, int cell = 6)
    {
        Bitmap pixelated = new System.Drawing.Bitmap(bmp.Width, bmp.Height);

        // make an exact copy of the bitmap provided
        using (Graphics graphics = System.Drawing.Graphics.FromImage(pixelated))
            graphics.DrawImage(bmp, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height),
                new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);

        // look at every pixel in the rectangle while making sure we're within the image bounds
        for (Int32 xx = area.X; xx < area.X + area.Width && xx < bmp.Width; xx += cell)
        {
            for (Int32 yy = area.Y; yy < area.Y + area.Height && yy < bmp.Height; yy += cell)
            {
                Int32 offsetX = cell / 2;
                Int32 offsetY = cell / 2;

                // make sure that the offset is within the boundry of the image
                while (xx + offsetX >= bmp.Width) offsetX--;
                while (yy + offsetY >= bmp.Height) offsetY--;

                // get the pixel color in the center of the soon to be pixelated area
                Color pixel = pixelated.GetPixel(xx + offsetX, yy + offsetY);

                // for each pixel in the pixelate size, set it to the center color
                for (Int32 x = xx; x < xx + cell && x < bmp.Width; x++)
                    for (Int32 y = yy; y < yy + cell && y < bmp.Height; y++)
                        pixelated.SetPixel(x, y, pixel);
            }
        }

        return pixelated;
    }


    private static Color AverageRectangle(Bitmap bmp, int x, int y, int width, int height)
    {
        if (x < 0)
            x = 0;
        if (x + width >= bmp.Width)
            width = bmp.Width - x - 1;

        if (y < 0)
            y = 0;
        if (y + height >= bmp.Height)
            height = bmp.Height - y - 1;

        if (width <= 0 | height <= 0)
            return Color.Black;

        Color clr = default(Color);
        var r = 0;
        var g = 0;
        var b = 0;

        for (var i = 0; i <= height - 1; i++)
        {
            for (var j = 0; j <= width - 1; j++)
            {
                clr = bmp.GetPixel(x + j, y + i);
                r += clr.R;
                g += clr.G;
                b += clr.B;
            }
        }

        r = Convert.ToInt32(r / (width * height));
        g = Convert.ToInt32(g / (width * height));
        b = Convert.ToInt32(b / (width * height));

        return Color.FromArgb(255, r, g, b);
    }
}
