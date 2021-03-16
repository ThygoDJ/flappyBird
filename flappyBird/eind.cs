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
    public partial class eind : Form
    {
            
        public eind(int numberOfLives, int Score)
        {
            InitializeComponent();
            scoreText.Text = "Eind score:" + Score.ToString();
            levensText2.Text = "Aantal levens; "  + numberOfLives.ToString();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void leven3_Click(object sender, EventArgs e)
        {

        }
    }
}
