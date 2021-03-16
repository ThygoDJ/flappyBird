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

        private void leven3_Click(object sender, EventArgs e)
        {

        }
    }
}
