
namespace flappyBird
{
    partial class highscores
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            this.start = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Plek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Score = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumTijd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(656, 610);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(244, 64);
            this.start.TabIndex = 2;
            this.start.Text = "terug";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.BackgroundImage = global::flappyBird.Properties.Resources.achtergrpnd_blauw_16_;
            this.listView1.BackgroundImageTiled = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Plek,
            this.Naam,
            this.Score,
            this.DatumTijd});
            this.listView1.HideSelection = false;
            listViewItem4.IndentCount = 1;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listView1.Location = new System.Drawing.Point(88, 48);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(768, 522);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Plek
            // 
            this.Plek.Text = "plek";
            this.Plek.Width = 90;
            // 
            // Naam
            // 
            this.Naam.Text = "Naam";
            this.Naam.Width = 90;
            // 
            // Score
            // 
            this.Score.Text = "Score";
            this.Score.Width = 90;
            // 
            // DatumTijd
            // 
            this.DatumTijd.Text = "Datum/Tijd";
            this.DatumTijd.Width = 110;
            // 
            // highscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flappyBird.Properties.Resources.flappy_bird_background_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 731);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.start);
            this.Name = "highscores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "highscores";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Plek;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Score;
        private System.Windows.Forms.ColumnHeader DatumTijd;
    }
}