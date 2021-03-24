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
        
        public eindscores(int eindscore)
        {
            InitializeComponent();
            eindScoreText.Text = "Eind score:" + eindscore.ToString();
        }
       
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void eindscores_Load(object sender, EventArgs e)
        {

        }

        private void eindScoreText_Click(object sender, EventArgs e)
        {

        }
    }
}
