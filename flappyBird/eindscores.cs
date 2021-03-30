using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flappyBird
{
    public partial class eindscores : Form
    {
        
        public eindscores(int highscore)
        {
            InitializeComponent();
            eindScoreText.Text = "Eind score:" + highscore.ToString();
        }
       
        
        

        private void eindscores_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            highscores scoreboard = new highscores();
            scoreboard.ShowDialog();
        }
    }
}
