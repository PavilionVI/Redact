using System;
using System.Drawing;

public class Pixelator
{
    public static Bitmap Pixelate(Bitmap src, Rectangle area, int cell = 5)
    {
        for (var xx = area.X; xx < area.X + area.Width && xx < src.Width; xx += cell)
            for (var yy = area.Y; yy < area.Y + area.Height && yy < src.Height; yy += cell)
            {
                var offsetX = cell / 2;
                var offsetY = offsetX;

                while (xx + offsetX >= src.Width)
                    offsetX--;

                while (yy + offsetY >= src.Height)
                    offsetY--;

                var pixel = src.GetPixel(xx + offsetX, yy + offsetY);

                for (var x = xx; x < xx + cell && x < src.Width; x++)
                    for (var y = yy; y < yy + cell && y < src.Height; y++)
                        src.SetPixel(x, y, pixel);
            }

        return src;
    }

    private static Color AverageRectangle(Bitmap src, int x, int y, int width, int height)
    {
        if (x < 0)
            x = 0;
        if (x + width >= src.Width)
            width = src.Width - x - 1;

        if (y < 0)
            y = 0;
        if (y + height >= src.Height)
            height = src.Height - y - 1;

        if (width <= 0 || height <= 0)
            return Color.Black;

        var clr = default(Color);
        var r = 0;
        var g = 0;
        var b = 0;

        for (var i = 0; i <= height - 1; i++)
            for (var j = 0; j <= width - 1; j++)
            {
                clr = src.GetPixel(x + j, y + i);
                r += clr.R;
                g += clr.G;
                b += clr.B;
            }

        r /= (width * height);
        g /= (width * height);
        b /= (width * height);

        return Color.FromArgb(255, r, g, b);
    }
}
