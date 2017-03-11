using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Color_Models
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool rgbflag = false, 
            hsv = false, 
            cmy = false, 
            luv = false;

        public MainWindow()
        {
            InitializeComponent();

            r_slider.Background = new LinearGradientBrush(Colors.Black, Color.FromRgb(255, 0, 0), 0.0);
            g_slider.Background = new LinearGradientBrush(Colors.Black, Color.FromRgb(0, 255, 0), 0.0);
            b_slider.Background = new LinearGradientBrush(Colors.Black, Color.FromRgb(0, 0, 255), 0.0);

            rTextBox.Text = "0";
            gTextBox.Text = "0";
            bTextBox.Text = "0";

        }

        #region Mouse Events
        private void rgb_slider_MouseEnter(object sender, MouseEventArgs e)
        {
            rgbflag = true;
        }

        private void rgb_slider_MouseLeave(object sender, MouseEventArgs e)
        {
            rgbflag = false;
        }

        private void cmy_slider_MouseEnter(object sender, MouseEventArgs e)
        {
            cmy = true;
        }

        private void cmy_slider_MouseLeave(object sender, MouseEventArgs e)
        {
            cmy = false;
        }

        private void hsv_slider_MouseEnter(object sender, MouseEventArgs e)
        {
            hsv = true;
        }

        private void hsv_slider_MouseLeave(object sender, MouseEventArgs e)
        {
            hsv = false;
        }

        private void luv_slider_MouseEnter(object sender, MouseEventArgs e)
        {
            luv = true;
        }

        private void luv_slider_MouseLeave(object sender, MouseEventArgs e)
        {
            luv = false;
        }

        #endregion

        #region Sliders Events
        private void rgb_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (rgbflag)
            {
                Color color = Color.FromRgb((byte)r_slider.Value, (byte)g_slider.Value, (byte)b_slider.Value);
                this.Background = new SolidColorBrush(color);   

                double[] cmy = ColorConverter.rgbToCMY((int)r_slider.Value, (int)g_slider.Value, (int)b_slider.Value);
                c_slider.Value = cmy[0];
                m_slider.Value = cmy[1];
                y_slider.Value = cmy[2];

                double[] hsv = ColorConverter.rgbToHSV((int)r_slider.Value, (int)g_slider.Value, (int)b_slider.Value);
                h_slider.Value = hsv[0];
                s_slider.Value = hsv[1];
                v_slider.Value = hsv[2];

                double[] luv = ColorConverter.rgbToLUV((int)r_slider.Value, (int)g_slider.Value, (int)b_slider.Value);
                l_slider.Value = luv[0];
                u_slider.Value = luv[1];
                vv_slider.Value = luv[2];

                #region RGB Text Boxes
                rTextBox.Text = Math.Round(r_slider.Value).ToString();
                gTextBox.Text = Math.Round(g_slider.Value).ToString();
                bTextBox.Text = Math.Round(b_slider.Value).ToString();
                #endregion
            }
            #region r slider gradient background
            Color rStartGradientColor = Color.FromRgb((byte)0, (byte)g_slider.Value, (byte)b_slider.Value);
            Color rEndGradientColor = Color.FromRgb((byte)255, (byte)g_slider.Value, (byte)b_slider.Value);
            r_slider.Background = new LinearGradientBrush(rStartGradientColor, rEndGradientColor, 0.0);
            #endregion
            #region g slider gradient background
            Color gStartGradientColor = Color.FromRgb((byte)r_slider.Value, (byte)0, (byte)b_slider.Value);
            Color gEndGradientColor = Color.FromRgb((byte)r_slider.Value, (byte)255, (byte)b_slider.Value);
            g_slider.Background = new LinearGradientBrush(gStartGradientColor, gEndGradientColor, 0.0);
            #endregion
            #region b slider gradient background
            Color bStartGradientColor = Color.FromRgb((byte)r_slider.Value, (byte)g_slider.Value, (byte)0);
            Color bEndGradientColor = Color.FromRgb((byte)r_slider.Value, (byte)g_slider.Value, (byte)255);
            b_slider.Background = new LinearGradientBrush(bStartGradientColor, bEndGradientColor, 0.0);
            #endregion
            
        }

        private void cmy_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (cmy)
            {
                int[] rgb = ColorConverter.cmyToRGB(c_slider.Value, m_slider.Value, y_slider.Value);
                Color color = Color.FromRgb((byte)rgb[0], (byte)rgb[1], (byte)rgb[2]);
                this.Background = new SolidColorBrush(color);
                    
                r_slider.Value = rgb[0];
                g_slider.Value = rgb[1];
                b_slider.Value = rgb[2];

                double[] hsv = ColorConverter.rgbToHSV(rgb[0], rgb[1], rgb[2]);
                h_slider.Value = hsv[0];
                s_slider.Value = hsv[1];
                v_slider.Value = hsv[2];

                double[] luv = ColorConverter.rgbToLUV(rgb[0], rgb[1], rgb[2]);
                l_slider.Value = luv[0];
                u_slider.Value = luv[1];
                vv_slider.Value = luv[2];

                #region RGB Text Boxes
                rTextBox.Text = Math.Round(r_slider.Value).ToString();
                gTextBox.Text = Math.Round(g_slider.Value).ToString();
                bTextBox.Text = Math.Round(b_slider.Value).ToString();
                #endregion
            }
        }
        
        private void hsv_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (hsv)
            {
                int[] rgb = ColorConverter.hsvToRgb(h_slider.Value, s_slider.Value, v_slider.Value);
                Color color = Color.FromRgb((byte)rgb[0], (byte)rgb[1], (byte)rgb[2]);
                this.Background = new SolidColorBrush(color);

                r_slider.Value = rgb[0];
                g_slider.Value = rgb[1];
                b_slider.Value = rgb[2];

                double[] cmy = ColorConverter.rgbToCMY(rgb[0], rgb[1], rgb[2]);
                c_slider.Value = cmy[0];
                m_slider.Value = cmy[1];
                y_slider.Value = cmy[2];

                double[] luv = ColorConverter.rgbToLUV(rgb[0], rgb[1], rgb[2]);
                l_slider.Value = luv[0];
                u_slider.Value = luv[1];
                vv_slider.Value = luv[2];

                #region RGB Text Boxes
                rTextBox.Text = Math.Round(r_slider.Value).ToString();
                gTextBox.Text = Math.Round(g_slider.Value).ToString();
                bTextBox.Text = Math.Round(b_slider.Value).ToString();
                #endregion
            }
        }

        // Last Values of LUV Sliders
        private double lvSliderL = 0;
        private double lvSliderU = 0;
        private double lvSliderV = 0;
        #region LUV Sliders_ValueChanged
        private void l_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (luv)
            {
                int[] rgb = ColorConverter.luvToRGB(l_slider.Value, u_slider.Value, vv_slider.Value);
                if (ColorConverter.checkLUV(rgb[0], rgb[1], rgb[2]))
                {
                    lvSliderL = l_slider.Value;
                    Color color = Color.FromRgb((byte)rgb[0], (byte)rgb[1], (byte)rgb[2]);
                    this.Background = new SolidColorBrush(color);

                    r_slider.Value = rgb[0];
                    g_slider.Value = rgb[1];
                    b_slider.Value = rgb[2];

                    double[] cmy = ColorConverter.rgbToCMY(rgb[0], rgb[1], rgb[2]);
                    c_slider.Value = cmy[0];
                    m_slider.Value = cmy[1];
                    y_slider.Value = cmy[2];

                    double[] hsv = ColorConverter.rgbToHSV(rgb[0], rgb[1], rgb[2]);
                    h_slider.Value = hsv[0];
                    s_slider.Value = hsv[1];
                    v_slider.Value = hsv[2];

                    #region RGB Text Boxes
                    rTextBox.Text = Math.Round(r_slider.Value).ToString();
                    gTextBox.Text = Math.Round(g_slider.Value).ToString();
                    bTextBox.Text = Math.Round(b_slider.Value).ToString();
                    #endregion
                }
                else
                {
                    l_slider.Value = lvSliderL;
                }
            }
        }

        private void rgb(object sender, TextChangedEventArgs e)
        {

        }

        private void u_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (luv)
            {
                int[] rgb = ColorConverter.luvToRGB(l_slider.Value, u_slider.Value, vv_slider.Value);
                if (ColorConverter.checkLUV(rgb[0], rgb[1], rgb[2]))
                {
                    lvSliderU = u_slider.Value;
                    Color color = Color.FromRgb((byte)rgb[0], (byte)rgb[1], (byte)rgb[2]);
                    this.Background = new SolidColorBrush(color);

                    r_slider.Value = rgb[0];
                    g_slider.Value = rgb[1];
                    b_slider.Value = rgb[2];


                    double[] cmy = ColorConverter.rgbToCMY(rgb[0], rgb[1], rgb[2]);
                    c_slider.Value = cmy[0];
                    m_slider.Value = cmy[1];
                    y_slider.Value = cmy[2];

                    double[] hsv = ColorConverter.rgbToHSV(rgb[0], rgb[1], rgb[2]);
                    h_slider.Value = hsv[0];
                    s_slider.Value = hsv[1];
                    v_slider.Value = hsv[2];

                    #region RGB Text Boxes
                    rTextBox.Text = Math.Round(r_slider.Value).ToString();
                    gTextBox.Text = Math.Round(g_slider.Value).ToString();
                    bTextBox.Text = Math.Round(b_slider.Value).ToString();
                    #endregion
                }
                else
                {
                    u_slider.Value = lvSliderU;
                }
            }
        }
        private void v_slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (luv)
            {
                int[] rgb = ColorConverter.luvToRGB(l_slider.Value, u_slider.Value, vv_slider.Value);
                if (ColorConverter.checkLUV(rgb[0], rgb[1], rgb[2]))
                {
                    lvSliderV = vv_slider.Value;
                    Color color = Color.FromRgb((byte)rgb[0], (byte)rgb[1], (byte)rgb[2]);
                    this.Background = new SolidColorBrush(color);

                    r_slider.Value = rgb[0];
                    g_slider.Value = rgb[1];
                    b_slider.Value = rgb[2];


                    double[] cmy = ColorConverter.rgbToCMY(rgb[0], rgb[1], rgb[2]);
                    c_slider.Value = cmy[0];
                    m_slider.Value = cmy[1];
                    y_slider.Value = cmy[2];

                    double[] hsv = ColorConverter.rgbToHSV(rgb[0], rgb[1], rgb[2]);
                    h_slider.Value = hsv[0];
                    s_slider.Value = hsv[1];
                    v_slider.Value = hsv[2];

                    #region RGB Text Boxes
                    rTextBox.Text = Math.Round(r_slider.Value).ToString();
                    gTextBox.Text = Math.Round(g_slider.Value).ToString();
                    bTextBox.Text = Math.Round(b_slider.Value).ToString();
                    #endregion
                }
                else
                {
                    vv_slider.Value = lvSliderV;
                }
            }
        }

        #endregion

        private void rgbTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(!(rgbflag || hsv || cmy || luv))
            {
                int red, green, blue;

                try
                {
                    red = int.Parse(rTextBox.Text);
                    green = int.Parse(gTextBox.Text);
                    blue = int.Parse(bTextBox.Text);
                }
                catch(Exception)
                {
                    red = 255;
                    green = 255;
                    blue = 255;
                }

                if (red < 0 || red > 255)
                    red = 255;
                if (green < 0 || green > 255)
                    green = 255;
                if (blue < 0 || blue > 255)
                    blue = 255;

                r_slider.Value = red;
                g_slider.Value = green;
                b_slider.Value = blue;
                Color color = Color.FromRgb((byte)r_slider.Value, (byte)g_slider.Value, (byte)b_slider.Value);
                this.Background = new SolidColorBrush(color);

                double[] cmy = ColorConverter.rgbToCMY((int)r_slider.Value, (int)g_slider.Value, (int)b_slider.Value);
                c_slider.Value = cmy[0];
                m_slider.Value = cmy[1];
                y_slider.Value = cmy[2];

                double[] hsv = ColorConverter.rgbToHSV((int)r_slider.Value, (int)g_slider.Value, (int)b_slider.Value);
                h_slider.Value = hsv[0];
                s_slider.Value = hsv[1];
                v_slider.Value = hsv[2];

                double[] luv = ColorConverter.rgbToLUV((int)r_slider.Value, (int)g_slider.Value, (int)b_slider.Value);
                l_slider.Value = luv[0];
                u_slider.Value = luv[1];
                vv_slider.Value = luv[2];
            }
        }

      
        #endregion

    }
}
