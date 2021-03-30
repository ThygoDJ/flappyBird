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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2 gamescherm = new form2();
            gamescherm.ShowDialog();
            
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            highscores scoreboard = new highscores();
            scoreboard.ShowDialog();

        }
    }
}
