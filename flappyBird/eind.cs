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

        // levens en score worden meegegeven vanuit form2
        public eind(int levens, int eindScore)
        {
            InitializeComponent();

            // de scoren en levens worden in een label geplaats
            scoreText.Text = "score:" + eindScore.ToString();
            levensText2.Text = "Aantal levens:" + levens.ToString();


            // als levens 2 zijn hide de form levens3
            if(levens == 2)
            {
                leven3.Hide();
            }
            // als levens 1 is hide de form levens3 en 2
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
