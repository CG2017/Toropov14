using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Models
{
    public static class ColorConverter
    {
        public static double[] rgbToCMY(int r, int g, int b)
        {
            double[] cmy = new double[3];
            cmy[0] = 1.0 - (r / 255.0);
            cmy[1] = 1.0 - (g / 255.0);
            cmy[2] = 1.0 - (b / 255.0);
            return cmy;
        }

        public static int[] cmyToRGB(double c, double m, double y)
        {
            int[] rgb = new int[3];
            rgb[0] = (int)((1 - c) * 255);
            rgb[1] = (int)((1 - m) * 255);
            rgb[2] = (int)((1 - y) * 255);
            return rgb;
        }

        public static double[] rgbToHSV(int red, int green, int blue)
        {
            double[] hsv = new double[3];

            double min = Math.Min(red, Math.Min(green, blue));
            double max = Math.Max(red, Math.Max(green, blue));
            hsv[2] = max;
            double delta = max - min;

            hsv[2] = max;

            if(hsv[2] == 0.0)
            {
                hsv[1] = 0;
            }
            else
            {
                hsv[1] = delta / hsv[2];
            }

            if (hsv[1] == 0)
            {
                hsv[0] = 0;
            }
            else
            {
                if (hsv[2] == red)
                    hsv[0] = (green - blue) / delta;
                else if (hsv[2] == green)
                    hsv[0] = 2 + (blue - red) / delta;
                else if (hsv[2] == blue)
                    hsv[0] = 4 + (red - green) / delta;
                hsv[0] *= 60;

                if (hsv[0] < 0.0)
                    hsv[0] += 360;
            }
            hsv[2] /= 255;

            return hsv;
        }

        public static int[] hsvToRgb(double h, double s, double v)
        {
            int[] rgb = new int[3];
            double r = 0;
            double g = 0;
            double b = 0;
            if (s == 0)
            {
                r = g = b = v;
            }
            else
            {
                // цветовой круг состоит из 6 секторов. Выяснить, в каком секторе
                // находится.
                double sectorPos = h / 60.0;
                int sectorNumber = (int)(Math.Floor(sectorPos));
                // получить дробную часть сектора
                double fractionalSector = sectorPos - sectorNumber;

                // вычислить значения для трех осей цвета.
                double p = v * (1.0 - s);
                double q = v * (1.0 - (s * fractionalSector));
                double t = v * (1.0 - (s * (1 - fractionalSector)));

                // присвоить дробные цвета r, g и b на основании сектора
                // угол равняется.
                switch (sectorNumber)
                {
                    case 0:
                        r = v;
                        g = t;
                        b = p;
                        break;
                    case 1:
                        r = q;
                        g = v;
                        b = p;
                        break;
                    case 2:
                        r = p;
                        g = v;
                        b = t;
                        break;
                    case 3:
                        r = p;
                        g = q;
                        b = v;
                        break;
                    case 4:
                        r = t;
                        g = p;
                        b = v;
                        break;
                    case 5:
                        r = v;
                        g = p;
                        b = q;
                        break;
                }
            }
            rgb[0] = Convert.ToInt32(Double.Parse(String.Format("{0:0.00}", r * 255.0)));
            rgb[1] = Convert.ToInt32(Double.Parse(String.Format("{0:0.00}", g * 255.0)));
            rgb[2] = Convert.ToInt32(Double.Parse(String.Format("{0:0.00}", b * 255.0)));

            return rgb;
        }

        #region Coeficients XYZ
        //Reference white - D65, sRGB
        private static double[,] coeficientsXYZ = {
            { 0.4124564, 0.3575761, 0.1804375}, 
            { 0.2126729, 0.7151522, 0.0721750},
            { 0.0193339, 0.1191920, 0.9503041}
        };
        private static double[,] reverseCoeficientsXYZ = {
            { 3.2404542, -1.5371385, -0.4985314},
            {-0.9692660,  1.8760108,  0.0415560},
            { 0.0556434, -0.2040259,  1.0572252}
        };
        #endregion
        public static int[] luvToRGB(double l, double u, double v)
        {
            double[] XYZn = new double[3];
            double[] whitePointRGB = { 1, 1, 1 };
            for(int j = 0; j < 3; j++)
            {
                XYZn[j] = 0;
                for(int i = 0; i < 3; i++)
                {
                    XYZn[j] += whitePointRGB[i] * coeficientsXYZ[j, i];
                }
            }

            double Un = 0, Vn = 0;
            if(XYZn[0] != 0)
            {
                Un = 4 * XYZn[0] / (XYZn[0] + 15 * XYZn[1] + 3 * XYZn[2]);
            }
            if(XYZn[1] != 0)
            {
                Vn = 9 * XYZn[1] / (XYZn[0] + 15 * XYZn[1] + 3 * XYZn[2]); 
            }

            double Uk = Un;
            double Vk = Vn;

            if(l != 0)
            {
                Uk += u / (13 * l);
                Vk += v / (13 * l);
            }

            double[] XYZ = new double[3];
            if(l <= 8)
            {
                XYZ[1] = XYZn[1] * l * Math.Pow(3.0 / 29, 3);
            }
            else
            {
                XYZ[1] = XYZn[1] * Math.Pow((l + 16) / 116, 3);
            }
            XYZ[0] = XYZ[1] * 9 * Uk / (4 * Vk);
            XYZ[2] = XYZ[1] * (12.0 - 3 * Uk - 20 * Vk) / (4 * Vk);

            double[] tRGB = new double[3];
            for(int j = 0; j < 3; j++)
            {
                tRGB[j] = 0;
                for(int i = 0; i < 3; i++)
                {
                    tRGB[j] += XYZ[i] * reverseCoeficientsXYZ[j, i];
                }
            }

            int[] RGB = new int[3];
            RGB[0] = Convert.ToInt32(tRGB[0] * 255.0);
            RGB[1] = Convert.ToInt32(tRGB[1] * 255.0);
            RGB[2] = Convert.ToInt32(tRGB[2] * 255.0);

            return RGB;
        }
        public static double[] rgbToLUV(int r, int g, int b)
        {
            double[] luv = new double[3];
            double[] xyz = new double[3];
            
            double[] rgb = { r/255.0, g/255.0, b/255.0 };
            for (int j = 0; j < 3; j++)
            {
                xyz[j] = 0;
                for (int i = 0; i < 3; i++)
                {
                    xyz[j] += rgb[i] * coeficientsXYZ[j, i];
                }
            }
            double[] xyzn = new double[3];
            double[] whitePointRGB = { 1, 1, 1 };
            for (int j = 0; j < 3; j++)
            {
                xyzn[j] = 0;
                for (int i = 0; i < 3; i++)
                {
                    xyzn[j] += whitePointRGB[i] * coeficientsXYZ[j, i];
                }
            }

            double Yn = xyzn[1];

            if(xyz[1] / Yn > 0.008856)
            {
                luv[0] = 116 * Math.Pow(xyz[1] / Yn, 1.0 / 3) - 16;
            }
            else
            {
                luv[0] = 903.3 * xyz[1] * Yn;
            }
            double uk = 0;
            double vk = 0;
            if(xyz[0] != 0)
            {
                uk = 4 * xyz[0] / (xyz[0] + 15 * xyz[1] + 3 * xyz[2]);
            }
            if(xyz[1] != 0)
            {
                vk = 9 * xyz[1] / (xyz[0] + 15 * xyz[1] + 3 * xyz[2]);
            }

            double un = 0;
            double vn = 0;
            if(xyzn[0] != 0)
            {
                un = 4 * xyzn[0] / (xyzn[0] + 15 * xyzn[1] + 3 * xyzn[2]);
            }
            if(xyzn[1] != 0)
            {
                vn = 9 * xyzn[1] / (xyzn[0] + 15 * xyzn[1] + 3 * xyzn[2]);
            }
            luv[1] = 13 * luv[0] * (uk - un);
            luv[2] = 13 * luv[0] * (vk - vn);

            return luv;
        }
        public static bool checkLUV(int r, int g, int b)
        {
            bool flag = true;
            int[] rgb = new int[3];
            if (r < 0)
            {
                rgb[0] = 0;
                flag = false;
            }
            if(g < 0)
            {
                rgb[1] = 0;
                flag = false;
            }
            if(b < 0)
            {
                rgb[2] = 0;
                flag = false;
            }
            if(r > 255)
            {
                rgb[0] = 255;
                flag = false;   
            }
            if(g > 255)
            {
                rgb[1] = 255;
                flag = false;
            }
            if(b > 255)
            {
                rgb[2] = 255;
                flag = false;
            }
            return flag;
        }

    }
}
