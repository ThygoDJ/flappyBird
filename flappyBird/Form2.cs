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
    

    public partial class form2 : Form
    {
        
        // Variabelen

        int pipeSpeed = 6; // snelheid aangegeven met getal
        int gravity = 8; // gravity aangegeven met getal
        int score = 0; // standaard score 0
        int levens = 3; // het aantal levens van flappy bird           
        int eindscore = 0;// uiteindelijke score
        int score5 = 5;
        // einde variabelen

        public form2()
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
            gameTimer.Stop();
            eindscore = eindscore + score;
            if (levens == 0)
            {
                eindScoreText.Text = "Eind score: " + eindscore.ToString();
            }
            
        }

        private void resetGame() // hierdoor zal de game compleet opnieuw gaan
        {
            flappyBird.Left = 106;
            flappyBird.Top = 244;
            
            buisB.Left = 679;
            buisB.Top = -258;

            BuisO.Left = 679;
            BuisO.Top = 448;

            
            score = 0;

            pipeSpeed = 6;

            score5 = 5;
 
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity; // hierdoor krijgt de flappybird gravity en snelheid
            BuisO.Left -= pipeSpeed;  // dit is de snelheid van de buis die dichterbij komt als je spatie drukt 
            buisB.Left -= pipeSpeed; // dit is de snelheid van de buis die dichterbij komt als je spatie drukt
            scoreText.Text = "Score: " + score.ToString(); // dit houd de score bij
            levensText.Text = "levens:" + levens.ToString(); // als hij dood gaat leven eraf


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
                gameTimer.Stop();

                if (levens == 2)
                {
                    eind eindscherm = new eind(levens, score);
                    eindscherm.ShowDialog();
                    
                    resetGame();
                    gameTimer.Start();
                 
                }
                if (levens == 1)
                {
                    eind eindscherm = new eind(levens, score);
                    eindscherm.ShowDialog();

                    resetGame();
                    gameTimer.Start();

                }
                if (levens == 0)
                {
                    eindscores opnieuwSpelen = new eindscores();
                    opnieuwSpelen.ShowDialog();

                    endGame();
                  
                }
            }
            if (score == score5)
            {
                pipeSpeed = pipeSpeed + 1;
                score5 = score5 + 5;

            } 

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }  
    }
}

