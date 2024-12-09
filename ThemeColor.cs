using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyLife_Pt2
{
    public class ThemeColors
    {
        public static List<Color> colors = new List<Color> {
            Color.FromArgb(235, 76, 66),
            Color.FromArgb(254, 40, 162),
            Color.FromArgb(83,68,238),
            Color.FromArgb(27,141,147),
            Color.FromArgb(52,100,12),
            Color.FromArgb(157,108,2),
            Color.FromArgb(139,194,10),
            Color.FromArgb(0,138,80),
            Color.FromArgb(247, 148, 60),
            Color.FromArgb(246, 74, 70),
        };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
