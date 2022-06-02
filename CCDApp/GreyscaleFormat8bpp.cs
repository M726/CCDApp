using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCDApp
{
    class GreyscaleFormat8bpp
    {
        public ColorPalette GreyScale8bpp => CalculateGreyscalePalette();

        private ColorPalette CalculateGreyscalePalette() //from https://stackoverflow.com/questions/8603596/how-can-i-define-a-8-bit-grayscale-image-directly
        {
            Bitmap bmp = new Bitmap(1, 1, PixelFormat.Format8bppIndexed);
            ColorPalette p = bmp.Palette;

            Color[] entries = p.Entries;
            for (int i = 0; i < 256; i++)
            {
                entries[i] = Color.FromArgb(i, i, i);
            }
            return p;
        }
    }
}
