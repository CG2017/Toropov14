using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColorMine.ColorSpaces;
using System.Drawing;

namespace Lab_2
{
    class LabImg
    {
        private List<List<Lab>> labPixels;
        private readonly int width;
        private readonly int height;
        private Rgb CreateRGBColor(Color color)
        {
            return new Rgb { R = color.R, G = color.G, B = color.B};
        }
        public LabImg(Image image)
        {
            labPixels = new List<List<Lab>>();
            width = image.Width;
            height = image.Height;
            ConvertToLAB(new Bitmap(image));
        }

        private void ConvertToLAB(Bitmap bitmap)
        {
            for(int i = 0; i < height; ++i)
            {
                List<Lab> pixelsRow = new List<Lab>();
                for(int j = 0; j < width; ++j)
                {
                    var pixel = bitmap.GetPixel(j, i);
                    pixelsRow.Add(CreateRGBColor(pixel).To<Lab>());
                }
                labPixels.Add(pixelsRow);
            }
        }

        public Image GetRGBImg()
        {
            Bitmap bitmap = new Bitmap(width, height);
            var i = -1;
            var j = 0;
            foreach(var row in labPixels)
            {
                ++i;
                foreach(var pixel in row)
                {
                    var rgbPixels = pixel.To<Rgb>();
                    bitmap.SetPixel(j++, i, Color.FromArgb((int)rgbPixels.R, (int)rgbPixels.G, (int)rgbPixels.B));
                }
                j = 0;
            }
            return bitmap;
        }

        private Lab GenerateDestinationColor(double dL, double dA, double dB, Lab labDC)
        {
            return new Lab { L = labDC.L + dL, A = labDC.A + dA, B = labDC.B + dB };
        }

        public void Replace(Color sourceColor, Color destinationColor, Int32 radius)
        {
            var labSC = CreateRGBColor(sourceColor).To<Lab>();
            var labDC = CreateRGBColor(destinationColor).To<Lab>();

            List<List<Lab>> processedImg = new List<List<Lab>>();
            foreach(var row in labPixels)
            {
                List<Lab> processedRow = new List<Lab>();
                foreach(var pixel in row)
                {
                    var dL = pixel.L - labSC.L;
                    var dA = pixel.A - labSC.A;
                    var dB = pixel.B - labSC.B;
                    processedRow.Add(Math.Sqrt(dL * dL + dA * dA + dB * dB) < radius ? GenerateDestinationColor(dL, dA, dB, labDC) : pixel);
                }
                processedImg.Add(processedRow);
            }

            labPixels = processedImg;
        }
    }
}
