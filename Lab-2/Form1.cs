using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        private Image sourceImg;
        private LabImg labImg;
        private Color originalColor;
        private Color destinationColor; 
        public Form1()
        {
            InitializeComponent();
        }
        #region Functions for work with Image
        PropertyInfo rectangleImgProperty = typeof(PictureBox).GetProperty("ImageRectangle",
              BindingFlags.GetProperty
            | BindingFlags.NonPublic
            | BindingFlags.Instance);
        private void SetOriginalColor(EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Bitmap original = (Bitmap)sourcePictureBox.Image;
            Rectangle rect = (Rectangle)rectangleImgProperty.GetValue(sourcePictureBox, null);
            if (rect.Contains(me.Location))
            {
                using (Bitmap copy = new Bitmap(sourcePictureBox.ClientSize.Width, sourcePictureBox.ClientSize.Height))
                {
                    using (Graphics g = Graphics.FromImage(copy))
                    {
                        g.DrawImage(sourcePictureBox.Image, rect);
                        originalColor = copy.GetPixel(me.X, me.Y);
                    }
                }
            }
            originalColorPictureBox.BackColor = originalColor;
        }
        private void SetColor(PictureBox pictureBox, ref Color color)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
                pictureBox.BackColor = color;
            }
        }
        private void ShowImg(PictureBox pictureBox, Image image)
        {
            pictureBox.Image = image;
            pictureBox.Refresh();
        }
        #endregion

        #region Events Listeners
        private void originalColorPictureBox_Click(object sender, EventArgs e)
        {
            SetColor(originalColorPictureBox, ref originalColor);
        }

        private void destinationColorPictureBox_Click(object sender, EventArgs e)
        {
            SetColor(destinationColorPictureBox, ref destinationColor);
        }

        private void replaceBtn_Click(object sender, EventArgs e)
        {
            labImg.Replace(originalColor, destinationColor, radiusTrackBar.Value);
            processedPictureBox.Image = labImg.GetRGBImg();
            processedPictureBox.Refresh();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            labImg = new LabImg(sourceImg);
            ShowImg(processedPictureBox, sourceImg);
        }

        private void sourcePictureBox_Click(object sender, EventArgs e)
        {
            if(sourcePictureBox.Image == null)
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileName = openFileDialog.FileName;
                    sourceImg = Image.FromFile(fileName);
                    labImg = new LabImg(sourceImg);
                    ShowImg(sourcePictureBox, sourceImg);
                    ShowImg(processedPictureBox, sourceImg);
                }
            }
            else
            {
                SetOriginalColor(e);
            }
        }

        private void radiusTrackBar_ValueChanged(object sender, EventArgs e)
        {
            radiusLbl.Text = radiusTrackBar.Value.ToString();
        }
        #endregion
    }
}
