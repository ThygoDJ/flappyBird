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
        int score5 = 0;
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
            

            eindscores opnieuwSpelen = new eindscores(eindscore);
            opnieuwSpelen.ShowDialog();
            Close();
        }

        private void resetGame() // hierdoor zal de game compleet opnieuw gaan
        {
            score = 0;

            pipeSpeed = 6;

            score5 = 5;

            flappyBird.Left = 250;
            flappyBird.Top = 100;

            buisB.Left = 520;
            buisB.Top = -135;

            buisB2.Left = 10;
            buisB2.Top = -135;

            BuisO.Left = 520; 
            BuisO.Top = 250;

            buisO2.Left = 10;
            buisO2.Top = 250;
            
            gameTimer.Start();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity; // hierdoor krijgt de flappybird gravity en snelheid
            BuisO.Left -= pipeSpeed;  // dit is de snelheid van de buis die dichterbij komt als je spatie drukt 
            buisB.Left -= pipeSpeed;// dit is de snelheid van de buis die dichterbij komt als je spatie drukt
            buisO2.Left -= pipeSpeed;  // dit is de snelheid van de buis die dichterbij komt als je spatie drukt 
            buisB2.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score.ToString(); // dit houd de score bij
            levensText.Text = "levens:" + levens.ToString(); // als hij dood gaat leven eraf


            var number = new Random();


            if (buisB.Left < -150)
            {
                // waarde bovenste buis
                int topBoven = number.Next(-190, -70);
                int leftboven = number.Next(700, 800);

                //waarden onderste buis
                int leftOnder = number.Next(700, 800);
                int topOnder = number.Next(240, 430);

                //dit zorgt voor de ruimte tussen de buis
                int ruimte = topOnder - 280;
                int ruimte2 = topBoven + 245;

                // dit is de ruimte tussen de buizen
                int totaleruimte = ruimte - ruimte2;

                if ((totaleruimte < 0) == true)
                {
                    // waarde waar de eerste bovenste buis komt als de ruimte kleiner is dan 0
                    buisB.Left = 800;
                    buisB.Top = -150;

                    // waarde waar de eerste onderste buis komt als de ruimte kleiner is dan 0
                    BuisO.Left = leftOnder;
                    BuisO.Top = 250;
                }

                if ((totaleruimte < 0) == false)
                {
                    // waarde waar de bovenste buis komt als de ruimte nie kleiner is dan 0
                    buisB.Left = leftboven;
                    buisB.Top = topBoven;
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
                        endGame();

                    }
                }
                if (score == score5)
                {
                    pipeSpeed = pipeSpeed += 1;
                    score5 = score5 + 5;

                }

            }

        }

        private void form2_Load(object sender, EventArgs e)
        {

        }
    }
}

