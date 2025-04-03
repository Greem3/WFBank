using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    static class PictureModifier
    {
        public static Image InvertColors(Image image)
        {
            Bitmap imageBitMap = new Bitmap(image);

            Bitmap bitmap = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color pixel = imageBitMap.GetPixel(x, y);
                    Color invertedPixel = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    bitmap.SetPixel(x, y, invertedPixel);
                }
            }

            return bitmap;
        }

        public static void InvertImageColors(PictureBox control)
        {
            control.Image = InvertColors(control.Image);
        }
    }
}
