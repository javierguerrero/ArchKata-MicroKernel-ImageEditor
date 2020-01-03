using PluginFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeColors
{
    public class MakeRed : IFilter
    {
        public string Name => "Make Red";

        public Image RunPlugin(Image src)
        {
            var bitmap = new Bitmap(src);
            for (int row = 0; row < bitmap.Height; ++row)
            {
                for (int col = 0; col < bitmap.Width; ++col)
                {
                    Color color = bitmap.GetPixel(col, row);
                    if (color.R > 0)
                    {
                        color = Color.FromArgb(color.A, 255, color.G, color.B);
                    }
                    bitmap.SetPixel(col, row, color);
                }
            }
            return bitmap;
        }
    }



}
