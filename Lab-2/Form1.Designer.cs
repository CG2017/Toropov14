namespace Lab_2
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
            this.sourcePictureBox = new System.Windows.Forms.PictureBox();
            this.processedPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.originalColorPictureBox = new System.Windows.Forms.PictureBox();
            this.destinationColorPictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.replaceBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.radiusTrackBar = new System.Windows.Forms.TrackBar();
            this.radiusLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // sourcePictureBox
            // 
            this.sourcePictureBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sourcePictureBox.Location = new System.Drawing.Point(12, 12);
            this.sourcePictureBox.Name = "sourcePictureBox";
            this.sourcePictureBox.Size = new System.Drawing.Size(769, 526);
            this.sourcePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sourcePictureBox.TabIndex = 0;
            this.sourcePictureBox.TabStop = false;
            this.sourcePictureBox.Click += new System.EventHandler(this.sourcePictureBox_Click);
            // 
            // processedPictureBox
            // 
            this.processedPictureBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.processedPictureBox.Location = new System.Drawing.Point(787, 12);
            this.processedPictureBox.Name = "processedPictureBox";
            this.processedPictureBox.Size = new System.Drawing.Size(726, 526);
            this.processedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.processedPictureBox.TabIndex = 1;
            this.processedPictureBox.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // originalColorPictureBox
            // 
            this.originalColorPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.originalColorPictureBox.Location = new System.Drawing.Point(681, 544);
            this.originalColorPictureBox.Name = "originalColorPictureBox";
            this.originalColorPictureBox.Size = new System.Drawing.Size(100, 50);
            this.originalColorPictureBox.TabIndex = 2;
            this.originalColorPictureBox.TabStop = false;
            this.originalColorPictureBox.Click += new System.EventHandler(this.originalColorPictureBox_Click);
            // 
            // destinationColorPictureBox
            // 
            this.destinationColorPictureBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.destinationColorPictureBox.Location = new System.Drawing.Point(787, 544);
            this.destinationColorPictureBox.Name = "destinationColorPictureBox";
            this.destinationColorPictureBox.Size = new System.Drawing.Size(100, 50);
            this.destinationColorPictureBox.TabIndex = 3;
            this.destinationColorPictureBox.TabStop = false;
            this.destinationColorPictureBox.Click += new System.EventHandler(this.destinationColorPictureBox_Click);
            // 
            // replaceBtn
            // 
            this.replaceBtn.Location = new System.Drawing.Point(724, 662);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(121, 43);
            this.replaceBtn.TabIndex = 4;
            this.replaceBtn.Text = "Change Color";
            this.replaceBtn.UseVisualStyleBackColor = true;
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(724, 709);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(121, 43);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // radiusTrackBar
            // 
            this.radiusTrackBar.Location = new System.Drawing.Point(587, 600);
            this.radiusTrackBar.Maximum = 100;
            this.radiusTrackBar.Name = "radiusTrackBar";
            this.radiusTrackBar.Size = new System.Drawing.Size(408, 56);
            this.radiusTrackBar.TabIndex = 7;
            this.radiusTrackBar.ValueChanged += new System.EventHandler(this.radiusTrackBar_ValueChanged);
            // 
            // radiusLbl
            // 
            this.radiusLbl.AutoSize = true;
            this.radiusLbl.Location = new System.Drawing.Point(1001, 610);
            this.radiusLbl.Name = "radiusLbl";
            this.radiusLbl.Size = new System.Drawing.Size(52, 17);
            this.radiusLbl.TabIndex = 8;
            this.radiusLbl.Text = "Radius";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "File...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 755);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radiusLbl);
            this.Controls.Add(this.radiusTrackBar);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.replaceBtn);
            this.Controls.Add(this.destinationColorPictureBox);
            this.Controls.Add(this.originalColorPictureBox);
            this.Controls.Add(this.processedPictureBox);
            this.Controls.Add(this.sourcePictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radiusTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sourcePictureBox;
        private System.Windows.Forms.PictureBox processedPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.PictureBox originalColorPictureBox;
        private System.Windows.Forms.PictureBox destinationColorPictureBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button replaceBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TrackBar radiusTrackBar;
        private System.Windows.Forms.Label radiusLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

