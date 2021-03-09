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
    public partial class Form1 : Form
    {



        // Variabelen

        int pipeSpeed = 8; // standaart snelheid aangegeven met getal
        int gravity = 15; // standaart gravity aangegeven met getal
        int score = 0; // standaard score 0
                       // einde variabelen

        public Form1()
        {
            InitializeComponent();
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            // dit is de gamekey die gekoppeld is aan naar beneden gaan
            if (e.KeyCode == Keys.Space)
            {
                // als je spatie indrukt word de gravity -15
                gravity = -15;
            }


        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            // dit is de toets die gekoppeld is aan naar boven gaan

            if (e.KeyCode == Keys.Space)
            {
                // als je de toets los laat word de gravity weer terug gezet naar 15
                gravity = 15;
            }

        }
    }
}

        