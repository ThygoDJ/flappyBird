
namespace flappyBird
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scoreText = new System.Windows.Forms.Label();
            this.Grond = new System.Windows.Forms.PictureBox();
            this.BuisO = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.buisB = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Grond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuisO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buisB)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Arial", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(24, 27);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(306, 80);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score: 0";
            // 
            // Grond
            // 
            this.Grond.Image = ((System.Drawing.Image)(resources.GetObject("Grond.Image")));
            this.Grond.Location = new System.Drawing.Point(-44, 632);
            this.Grond.Name = "Grond";
            this.Grond.Size = new System.Drawing.Size(1030, 238);
            this.Grond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Grond.TabIndex = 15;
            this.Grond.TabStop = false;
            // 
            // BuisO
            // 
            this.BuisO.Image = global::flappyBird.Properties.Resources.pipeUp1;
            this.BuisO.Location = new System.Drawing.Point(679, 410);
            this.BuisO.Name = "BuisO";
            this.BuisO.Size = new System.Drawing.Size(104, 532);
            this.BuisO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BuisO.TabIndex = 14;
            this.BuisO.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(72, 268);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(98, 104);
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
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 754);
            this.Controls.Add(this.Grond);
            this.Controls.Add(this.BuisO);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.buisB);
            this.Controls.Add(this.scoreText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Grond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuisO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buisB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.PictureBox buisB;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox BuisO;
        private System.Windows.Forms.PictureBox Grond;
        private System.Windows.Forms.Timer gameTimer;
    }
}

