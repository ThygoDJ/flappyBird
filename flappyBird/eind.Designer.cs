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
            this.eindscoreText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.levensText2 = new System.Windows.Forms.Label();
            this.leven3 = new System.Windows.Forms.PictureBox();
            this.leven1 = new System.Windows.Forms.PictureBox();
            this.leven2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leven3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leven1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leven2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // eindscoreText
            // 
            this.eindscoreText.AutoSize = true;
            this.eindscoreText.BackColor = System.Drawing.Color.Transparent;
            this.eindscoreText.Font = new System.Drawing.Font("Impact", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eindscoreText.Location = new System.Drawing.Point(0, 559);
            this.eindscoreText.Name = "eindscoreText";
            this.eindscoreText.Size = new System.Drawing.Size(325, 71);
            this.eindscoreText.TabIndex = 4;
            this.eindscoreText.Text = "Eindscore: 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::flappyBird.Properties.Resources.game_over__2_;
            this.pictureBox1.Location = new System.Drawing.Point(128, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(612, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // levensText2
            // 
            this.levensText2.AutoSize = true;
            this.levensText2.BackColor = System.Drawing.Color.Transparent;
            this.levensText2.Font = new System.Drawing.Font("Impact", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levensText2.Location = new System.Drawing.Point(0, 488);
            this.levensText2.Name = "levensText2";
            this.levensText2.Size = new System.Drawing.Size(365, 71);
            this.levensText2.TabIndex = 6;
            this.levensText2.Text = "Levens over: 3";
            // 
            // leven3
            // 
            this.leven3.Image = global::flappyBird.Properties.Resources.hartje;
            this.leven3.Location = new System.Drawing.Point(541, 292);
            this.leven3.Name = "leven3";
            this.leven3.Size = new System.Drawing.Size(112, 98);
            this.leven3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leven3.TabIndex = 7;
            this.leven3.TabStop = false;
            this.leven3.Click += new System.EventHandler(this.leven3_Click);
            // 
            // leven1
            // 
            this.leven1.Image = global::flappyBird.Properties.Resources.hartje;
            this.leven1.Location = new System.Drawing.Point(206, 292);
            this.leven1.Name = "leven1";
            this.leven1.Size = new System.Drawing.Size(121, 98);
            this.leven1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leven1.TabIndex = 8;
            this.leven1.TabStop = false;
            // 
            // leven2
            // 
            this.leven2.Image = global::flappyBird.Properties.Resources.hartje;
            this.leven2.Location = new System.Drawing.Point(375, 292);
            this.leven2.Name = "leven2";
            this.leven2.Size = new System.Drawing.Size(116, 98);
            this.leven2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leven2.TabIndex = 9;
            this.leven2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::flappyBird.Properties.Resources.opnieuw;
            this.pictureBox2.Location = new System.Drawing.Point(436, 628);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(466, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.button2_Click);
            // 
            // eind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flappyBird.Properties.Resources.game_over_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 802);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.leven2);
            this.Controls.Add(this.leven1);
            this.Controls.Add(this.leven3);
            this.Controls.Add(this.levensText2);
            this.Controls.Add(this.eindscoreText);
            this.Controls.Add(this.pictureBox1);
            this.Name = "eind";
            this.Text = "eind";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leven3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leven1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leven2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label eindscoreText;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label levensText2;
        private System.Windows.Forms.PictureBox leven3;
        private System.Windows.Forms.PictureBox leven1;
        private System.Windows.Forms.PictureBox leven2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}