﻿using System;
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
            //variabelen
            score = 0;
            pipeSpeed = 6;
            score5 = 5;
            //variabelen

            // de plaats waar flappy bird spawnt
            flappyBird.Left = 100;
            flappyBird.Top = 106;

            // dit geeft de plaats aan waar de eerste bovenste buis spawnt
            buisB.Left = 520;
            buisB.Top = -135;

            // dit geeft de plaats aan waar de tweede bovenste buis spawnt
            buisB2.Left = 10;
            buisB2.Top = -165;
            
            // dit geeft de plaats aan waar de eerste onderste buis spawnt
            BuisO.Left = 520;
            BuisO.Top = 250;

            // dit geeft de plaats aan waar de tweede onderste buis spawnt
            buisO2.Left = 10;
            buisO2.Top = 210;

            gameTimer.Start();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;    // hierdoor krijgt de flappybird gravity en snelheid
            BuisO.Left -= pipeSpeed;     // dit is de snelheid van de eerste onderste buis
            buisB.Left -= pipeSpeed;    // dit is de snelheid van de eerste bovenste buis
            buisO2.Left -= pipeSpeed;  // dit is de snelheid van de tweede onderste buis 
            buisB2.Left -= pipeSpeed; // dit is de snelheid van de tweede bovenste buis
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

            if (buisO2.Left < -150)
            {
                int nummer = number.Next(1100, 1200);// dit zorgt ervoor dat de buis random spawnt

                buisO2.Left = nummer;

            }

            if (buisB2.Left < -150)
            {
                int nummer = number.Next(1100, 1200);


                buisB2.Left = nummer;
                score++;
            }

            if (buisB.Bounds.IntersectsWith(buisB2.Bounds) ||
                BuisO.Bounds.IntersectsWith(buisO2.Bounds))
            {
                buisB.Left = 560;
                BuisO.Left = 500;

                buisB2.Left = 1100;
                buisO2.Left = 1050;
            }
            

            if (flappyBird.Bounds.IntersectsWith(BuisO.Bounds) ||
            flappyBird.Bounds.IntersectsWith(buisB.Bounds) ||
            flappyBird.Bounds.IntersectsWith(buisO2.Bounds) ||
            flappyBird.Bounds.IntersectsWith(buisB2.Bounds) ||
            flappyBird.Bounds.IntersectsWith(grond.Bounds) || flappyBird.Top < -25
          ) // dit zorgt ervoor wanneer flappy bird een buis of de grond raakt hij verder gaat in het if statement
            {
                // als hij word geraakt gaat er een leven af
                levens = levens - 1;
                gameTimer.Stop();

                if (levens == 2)
                {
                    // als de levens 2 zijn zal hij naar eindscherm gaan
                    eind eindscherm = new eind(levens, score);
                    eindscherm.ShowDialog();

                    resetGame();
                    gameTimer.Start();

                }
                if (levens == 1)
                {
                    // als de levens 2 zijn zal hij naar eindscherm gaan
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

        private void form2_Load(object sender, EventArgs e)
        {

        }
    }
}









