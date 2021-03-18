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


        public eind(int levens, int eindScore)
        {
            InitializeComponent();
            scoreText.Text = "score:" + eindScore.ToString();
            levensText2.Text = "Aantal levens:" + levens.ToString();

            if(levens == 2)
            {
                leven3.Hide();
            }
            if (levens == 1)
            {
                leven3.Hide();
                leven2.Hide();
            }
        }
       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
