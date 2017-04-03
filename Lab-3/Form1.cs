using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sourcePictureBox.Image = Bitmap.FromFile(openFileDialog.FileName);
                PaintDiagram(Color.Red, 256, color => color.R, rChartChannel, rTextBoxAverage);
                PaintDiagram(Color.Green, 256, color => color.G, gChartChannel, gTextBoxAverage);
                PaintDiagram(Color.Blue, 256, color => color.B, bChartChannel, bTextBoxAverage);
            }
        }

        private void PaintDiagram(Color color, int size, Func<Color, int> indexSelector,
            Chart chartChannel, TextBox textBoxAverage)
        {
            Bitmap bitmap = sourcePictureBox.Image as Bitmap;
            if (bitmap == null)
                return;

            int[] statistics = new int[size];
                
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color curPixel = bitmap.GetPixel(x, y);
                    statistics[indexSelector(curPixel)]++;
                }
            }

            long sumPixels = 0;
            long sumColor = 0;
            for (int i = 0; i < statistics.Length; i++)
            {
                sumPixels += statistics[i];
                sumColor += statistics[i] * i;
            }

            int average = (int)((double)sumColor / sumPixels);
            textBoxAverage.Text = average.ToString();

            chartChannel.Series["channel"].Color = color;
            chartChannel.Series["channel"].Points.Clear();
            for (int i = 0; i < statistics.Length; i++)
            {
                chartChannel.Series["channel"].Points.AddXY(i, statistics[i] + 1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
