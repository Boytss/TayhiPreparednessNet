﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DISASTER_PREPAREDNESS
{
    public static class ModernUI
    {
        public static List<string> ColorList = new List<string>()
        {
            "#38AA93",
            "#38AA93",
            "#38AA93",
            "#38AA93",
            "#38AA93",
            "#38AA93",
            "#38AA93",
            "#38AA93",
            "#38AA93",
            "#38AA93", };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            if(correctionFactor < 0)
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
