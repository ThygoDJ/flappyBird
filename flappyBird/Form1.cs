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

        int pipeSpeed = 6 ; // snelheid aangegeven met getal
        int gravity = 8; // gravity aangegeven met getal
        int score = 0; // standaard score 0
        int levens = 3; // het aantal levens van flappy bird           
       
        // einde variabelen
        
        public Form1()
        {
            InitializeComponent();
            TimeSpan sleep = TimeSpan.FromMilliseconds(90);
        }



        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            // dit is de gamekey die gekoppeld is aan naar beneden gaan
            if (e.KeyCode == Keys.Space)
            {
                // als je spatie indrukt word de gravity -15
                gravity = -8;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            // dit is de toets die gekoppeld is aan naar boven gaan

            if (e.KeyCode == Keys.Space)
            {
                // als je de toets los laat word de gravity weer terug gezet naar 15
                gravity = 8;
                
            }
        }
        private void endGame()
        {
            // hierdoor stopt de game 
            gameTimer.Stop(); // stop de timer
            scoreText.Text += " Game over"; // laat zien game over in beeld
        }
                   
        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity; // hierdoor krijgt de flappybird gravity en snelheid
            BuisO.Left -= pipeSpeed;  // dit is de snelheid van de buis die dichterbij komt als je spatie drukt 
            buisB.Left -= pipeSpeed; // dit is de snelheid van de buis die dichterbij komt als je spatie drukt
            scoreText.Text = "Score: " + score; // dit houd de score bij
            levensText.Text = "levens:" + levens.ToString() ; // als hij dood gaat leven eraf

            var number = new Random();

            if (BuisO.Left < -150)
            {
                int nummer = number.Next(700, 800); // dit zorgt ervoor dat de buis random spawnt

                BuisO.Left = nummer; // als de buis op -150 is gaat hij weer tussen 700 en 800 
            }
            
            if (buisB.Left < -150)
            {
                int nummer = number.Next(700, 800);// dit zorgt ervoor dat de buis random spawnt


                buisB.Left = nummer; // ls de buis op -180 is gaat hij weer tussen 700 en 800 en er komt 1 punt bij de score
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(BuisO.Bounds) ||
                flappyBird.Bounds.IntersectsWith(buisB.Bounds) ||
                flappyBird.Bounds.IntersectsWith(Grond.Bounds) || flappyBird.Top < -25
              ) // dit zorgt ervoor wanneer flappy bird een buis of de grond raakt hij verder gaat in het if statement
            {
                // als hij word geraakt gaat er een leven af
                levens = levens - 1;
                
                
            }

            if (levens == 0)
            { 
                endGame(); // het spel stopt als flappy bird 0 levens heeft
            }

            if (score >+  5)
            {
                pipeSpeed = 10 + 2;
            }
            

        }

        
    }
}

