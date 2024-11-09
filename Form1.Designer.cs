
namespace SayisalGoruntuIsleme
{

    partial class Form1
    {


        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.özellikler = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(514, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(1098, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(494, 444);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(593, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Resim Yükle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(593, 653);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 46);
            this.button3.TabIndex = 17;
            this.button3.Text = "Histogram";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(1161, 668);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(314, 56);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // özellikler
            // 
            this.özellikler.AutoSize = true;
            this.özellikler.Location = new System.Drawing.Point(1158, 616);
            this.özellikler.Name = "özellikler";
            this.özellikler.Size = new System.Drawing.Size(46, 17);
            this.özellikler.TabIndex = 19;
            this.özellikler.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(593, 757);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 46);
            this.button2.TabIndex = 20;
            this.button2.Text = "Binary";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(593, 705);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(300, 46);
            this.button4.TabIndex = 21;
            this.button4.Text = "RGB Dönüştür";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(593, 809);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(300, 46);
            this.button5.TabIndex = 25;
            this.button5.Text = "Kernel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(593, 861);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(300, 46);
            this.button6.TabIndex = 26;
            this.button6.Text = "Sobel";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxRed
            // 
            this.textBoxRed.BackColor = System.Drawing.Color.Red;
            this.textBoxRed.Location = new System.Drawing.Point(1161, 720);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(84, 22);
            this.textBoxRed.TabIndex = 27;
            this.textBoxRed.TextChanged += new System.EventHandler(this.textBoxRed_TextChanged);
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.BackColor = System.Drawing.Color.Blue;
            this.textBoxBlue.Location = new System.Drawing.Point(1277, 720);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(84, 22);
            this.textBoxBlue.TabIndex = 28;
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.BackColor = System.Drawing.Color.Green;
            this.textBoxGreen.Location = new System.Drawing.Point(1377, 720);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(84, 22);
            this.textBoxGreen.TabIndex = 29;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1161, 772);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(300, 46);
            this.button7.TabIndex = 30;
            this.button7.Text = "Erozyon";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1161, 824);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(300, 46);
            this.button8.TabIndex = 31;
            this.button8.Text = "Dilation";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1514, 915);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBoxGreen);
            this.Controls.Add(this.textBoxBlue);
            this.Controls.Add(this.textBoxRed);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.özellikler);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label özellikler;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }

}

