﻿
namespace flappyBird
{
    partial class eind
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
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.eindscoreText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.levensText2 = new System.Windows.Forms.Label();
            this.leven3 = new System.Windows.Forms.PictureBox();
            this.leven1 = new System.Windows.Forms.PictureBox();
            this.leven2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leven3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leven1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leven2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Impact", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(335, 611);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 97);
            this.button2.TabIndex = 3;
            this.button2.Text = "opnieuw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // eindscoreText
            // 
            this.eindscoreText.AutoSize = true;
            this.eindscoreText.BackColor = System.Drawing.Color.Transparent;
            this.eindscoreText.Font = new System.Drawing.Font("Impact", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eindscoreText.Location = new System.Drawing.Point(12, 21);
            this.eindscoreText.Name = "eindscoreText";
            this.eindscoreText.Size = new System.Drawing.Size(330, 71);
            this.eindscoreText.TabIndex = 4;
            this.eindscoreText.Text = "eindscore: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::flappyBird.Properties.Resources.game_over;
            this.pictureBox1.Location = new System.Drawing.Point(2, -58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(910, 686);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // levensText2
            // 
            this.levensText2.AutoSize = true;
            this.levensText2.BackColor = System.Drawing.Color.Transparent;
            this.levensText2.Font = new System.Drawing.Font("Impact", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levensText2.Location = new System.Drawing.Point(12, 104);
            this.levensText2.Name = "levensText2";
            this.levensText2.Size = new System.Drawing.Size(359, 71);
            this.levensText2.TabIndex = 6;
            this.levensText2.Text = "levens over: 3";
            // 
            // leven3
            // 
            this.leven3.Image = global::flappyBird.Properties.Resources.hartje;
            this.leven3.Location = new System.Drawing.Point(569, 392);
            this.leven3.Name = "leven3";
            this.leven3.Size = new System.Drawing.Size(136, 122);
            this.leven3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leven3.TabIndex = 7;
            this.leven3.TabStop = false;
            // 
            // leven1
            // 
            this.leven1.Image = global::flappyBird.Properties.Resources.hartje;
            this.leven1.Location = new System.Drawing.Point(206, 392);
            this.leven1.Name = "leven1";
            this.leven1.Size = new System.Drawing.Size(136, 122);
            this.leven1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leven1.TabIndex = 8;
            this.leven1.TabStop = false;
            // 
            // leven2
            // 
            this.leven2.Image = global::flappyBird.Properties.Resources.hartje;
            this.leven2.Location = new System.Drawing.Point(383, 392);
            this.leven2.Name = "leven2";
            this.leven2.Size = new System.Drawing.Size(136, 122);
            this.leven2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leven2.TabIndex = 9;
            this.leven2.TabStop = false;
            // 
            // eind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flappyBird.Properties.Resources.game_over_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 802);
            this.Controls.Add(this.leven2);
            this.Controls.Add(this.leven1);
            this.Controls.Add(this.leven3);
            this.Controls.Add(this.levensText2);
            this.Controls.Add(this.eindscoreText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "eind";
            this.Text = "eind";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leven3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leven1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leven2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label eindscoreText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label levensText2;
        private System.Windows.Forms.PictureBox leven3;
        private System.Windows.Forms.PictureBox leven1;
        private System.Windows.Forms.PictureBox leven2;
    }
}