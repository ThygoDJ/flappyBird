namespace flappyBird
{
    
        partial class form2

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form2));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.levensText = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.BuisO = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.buisB = new System.Windows.Forms.PictureBox();
            this.buisB2 = new System.Windows.Forms.PictureBox();
            this.buisO2 = new System.Windows.Forms.PictureBox();
            this.grond = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BuisO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buisB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buisB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buisO2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grond)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // levensText
            // 
            this.levensText.AutoSize = true;
            this.levensText.BackColor = System.Drawing.Color.Transparent;
            this.levensText.Font = new System.Drawing.Font("Comic Sans MS", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levensText.ForeColor = System.Drawing.SystemColors.Window;
            this.levensText.Location = new System.Drawing.Point(14, 88);
            this.levensText.Name = "levensText";
            this.levensText.Size = new System.Drawing.Size(214, 60);
            this.levensText.TabIndex = 16;
            this.levensText.Text = "levens: 3";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Comic Sans MS", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.SystemColors.Window;
            this.scoreText.Location = new System.Drawing.Point(14, 28);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(209, 60);
            this.scoreText.TabIndex = 17;
            this.scoreText.Text = "Score: 0";
            // 
            // BuisO
            // 
            this.BuisO.Image = global::flappyBird.Properties.Resources.pipeUp1;
            this.BuisO.Location = new System.Drawing.Point(679, 448);
            this.BuisO.Name = "BuisO";
            this.BuisO.Size = new System.Drawing.Size(104, 532);
            this.BuisO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BuisO.TabIndex = 14;
            this.BuisO.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(106, 244);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(90, 92);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 12;
            this.flappyBird.TabStop = false;
            // 
            // buisB
            // 
            this.buisB.Image = ((System.Drawing.Image)(resources.GetObject("buisB.Image")));
            this.buisB.Location = new System.Drawing.Point(679, -258);
            this.buisB.Name = "buisB";
            this.buisB.Size = new System.Drawing.Size(104, 486);
            this.buisB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buisB.TabIndex = 9;
            this.buisB.TabStop = false;
            // 
            // buisB2
            // 
            this.buisB2.Image = ((System.Drawing.Image)(resources.GetObject("buisB2.Image")));
            this.buisB2.Location = new System.Drawing.Point(1546, -355);
            this.buisB2.Name = "buisB2";
            this.buisB2.Size = new System.Drawing.Size(104, 486);
            this.buisB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buisB2.TabIndex = 18;
            this.buisB2.TabStop = false;
            // 
            // buisO2
            // 
            this.buisO2.Image = global::flappyBird.Properties.Resources.pipeUp1;
            this.buisO2.Location = new System.Drawing.Point(1546, 364);
            this.buisO2.Name = "buisO2";
            this.buisO2.Size = new System.Drawing.Size(104, 532);
            this.buisO2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buisO2.TabIndex = 19;
            this.buisO2.TabStop = false;
            // 
            // grond
            // 
            this.grond.Image = ((System.Drawing.Image)(resources.GetObject("grond.Image")));
            this.grond.Location = new System.Drawing.Point(-19, 607);
            this.grond.Name = "grond";
            this.grond.Size = new System.Drawing.Size(1030, 238);
            this.grond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.grond.TabIndex = 20;
            this.grond.TabStop = false;
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = global::flappyBird.Properties.Resources.achtergrpnd_blauw_16_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 786);
            this.Controls.Add(this.grond);
            this.Controls.Add(this.buisO2);
            this.Controls.Add(this.buisB2);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.levensText);
            this.Controls.Add(this.BuisO);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.buisB);
            this.DoubleBuffered = true;
            this.Name = "form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.BuisO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buisB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buisB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buisO2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox buisB;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox BuisO;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label levensText;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox buisB2;
        private System.Windows.Forms.PictureBox buisO2;
        private System.Windows.Forms.PictureBox grond;
    }
}

