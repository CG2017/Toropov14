namespace Lab_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rChartChannel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sourcePictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.rTextBoxAverage = new System.Windows.Forms.TextBox();
            this.gChartChannel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bChartChannel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gTextBoxAverage = new System.Windows.Forms.TextBox();
            this.bTextBoxAverage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rChartChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gChartChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bChartChannel)).BeginInit();
            this.SuspendLayout();
            // 
            // rChartChannel
            // 
            chartArea1.Name = "ChannelArea";
            this.rChartChannel.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.rChartChannel.Legends.Add(legend1);
            this.rChartChannel.Location = new System.Drawing.Point(507, 13);
            this.rChartChannel.Margin = new System.Windows.Forms.Padding(4);
            this.rChartChannel.Name = "rChartChannel";
            this.rChartChannel.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.rChartChannel.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series1.ChartArea = "ChannelArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "channel";
            this.rChartChannel.Series.Add(series1);
            this.rChartChannel.Size = new System.Drawing.Size(1269, 312);
            this.rChartChannel.TabIndex = 0;
            this.rChartChannel.Text = "Red";
            // 
            // sourcePictureBox
            // 
            this.sourcePictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sourcePictureBox.Location = new System.Drawing.Point(12, 12);
            this.sourcePictureBox.Name = "sourcePictureBox";
            this.sourcePictureBox.Size = new System.Drawing.Size(488, 402);
            this.sourcePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sourcePictureBox.TabIndex = 1;
            this.sourcePictureBox.TabStop = false;
            this.sourcePictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // rTextBoxAverage
            // 
            this.rTextBoxAverage.Location = new System.Drawing.Point(1632, 92);
            this.rTextBoxAverage.Name = "rTextBoxAverage";
            this.rTextBoxAverage.Size = new System.Drawing.Size(100, 22);
            this.rTextBoxAverage.TabIndex = 2;
            // 
            // gChartChannel
            // 
            chartArea2.Name = "ChannelArea";
            this.gChartChannel.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.gChartChannel.Legends.Add(legend2);
            this.gChartChannel.Location = new System.Drawing.Point(507, 333);
            this.gChartChannel.Margin = new System.Windows.Forms.Padding(4);
            this.gChartChannel.Name = "gChartChannel";
            this.gChartChannel.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.gChartChannel.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Green};
            series2.ChartArea = "ChannelArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Legend = "Legend1";
            series2.Name = "channel";
            this.gChartChannel.Series.Add(series2);
            this.gChartChannel.Size = new System.Drawing.Size(1269, 312);
            this.gChartChannel.TabIndex = 4;
            this.gChartChannel.Text = "Green";
            // 
            // bChartChannel
            // 
            chartArea3.Name = "ChannelArea";
            this.bChartChannel.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.bChartChannel.Legends.Add(legend3);
            this.bChartChannel.Location = new System.Drawing.Point(507, 653);
            this.bChartChannel.Margin = new System.Windows.Forms.Padding(4);
            this.bChartChannel.Name = "bChartChannel";
            this.bChartChannel.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.bChartChannel.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue};
            series3.ChartArea = "ChannelArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Legend = "Legend1";
            series3.Name = "channel";
            this.bChartChannel.Series.Add(series3);
            this.bChartChannel.Size = new System.Drawing.Size(1269, 312);
            this.bChartChannel.TabIndex = 5;
            this.bChartChannel.Text = "Blue";
            // 
            // gTextBoxAverage
            // 
            this.gTextBoxAverage.Location = new System.Drawing.Point(1632, 402);
            this.gTextBoxAverage.Name = "gTextBoxAverage";
            this.gTextBoxAverage.Size = new System.Drawing.Size(100, 22);
            this.gTextBoxAverage.TabIndex = 6;
            // 
            // bTextBoxAverage
            // 
            this.bTextBoxAverage.Location = new System.Drawing.Point(1632, 724);
            this.bTextBoxAverage.Name = "bTextBoxAverage";
            this.bTextBoxAverage.Size = new System.Drawing.Size(100, 22);
            this.bTextBoxAverage.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1789, 1045);
            this.Controls.Add(this.bTextBoxAverage);
            this.Controls.Add(this.gTextBoxAverage);
            this.Controls.Add(this.bChartChannel);
            this.Controls.Add(this.gChartChannel);
            this.Controls.Add(this.rTextBoxAverage);
            this.Controls.Add(this.sourcePictureBox);
            this.Controls.Add(this.rChartChannel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rChartChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gChartChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bChartChannel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart rChartChannel;
        private System.Windows.Forms.PictureBox sourcePictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox rTextBoxAverage;
        private System.Windows.Forms.DataVisualization.Charting.Chart gChartChannel;
        private System.Windows.Forms.DataVisualization.Charting.Chart bChartChannel;
        private System.Windows.Forms.TextBox gTextBoxAverage;
        private System.Windows.Forms.TextBox bTextBoxAverage;
    }
}

