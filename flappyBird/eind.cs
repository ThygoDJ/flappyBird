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
             // Variabelen

            int pipeSpeed = 6; // snelheid aangegeven met getal
            int gravity = 8; // gravity aangegeven met getal
            int score = 0; // standaard score 0
            int levens = 3; // het aantal levens van flappy bird           
            int eindscore = 0;// uiteindelijke score
            int score5 = 5;
            // einde variabelen
            
        public eind()
        {
            InitializeComponent();
        }

        private void resetGame() // hierdoor zal de game compleet opnieuw gaan
        {
            score = 0;

            pipeSpeed = 10;

            score5 = 5;
            
           gameTimerEvent.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            resetGame();
        }
    }
}
