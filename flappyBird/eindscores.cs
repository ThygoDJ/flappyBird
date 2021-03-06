using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace flappyBird
{
    public partial class eindscores : Form
    {
        //variabelen
        private int playerScore = 0;

        private int placement = 1;

        private int lowestPlayerScore = 0;

        private MySqlConnection connection;
        //einde variabelen

        public eindscores(int eindscore)
        {
            InitializeComponent();

            InitializeDatabaseConnection();
            
            pnlHighscore.Hide();

            playerScore = eindscore;

            eindScoreText.Text = "Eind score:" + playerScore.ToString();


            lowestScore(1);
            // als de spe;er score hoger is dan de laagste speler score voert hij deze if uit
            if (playerScore > lowestPlayerScore)
            {
                pnlHighscore.Show();



                lowestScore(10);


                // als je eerste bent geworden voert hij de if uit anders de else
                if (placement > 1)
                {
                    lblHighScoreInfo.Text = "NEW HIGHSCORE, u bent " + placement.ToString() + "e geplaatst" + "\r\n" + "vul hieronder uw naam in" + "\r\n" + "(waarschuwing: andere spelers kunnen de gekozen naam zien)";
                }
                else
                {
                    lblHighScoreInfo.Text = "NEW HIGHSCORE, u bent " + placement.ToString() + "st geplaatst" + "\r\n" + "vul hieronder uw naam in" + "\r\n" + "(waarschuwing: andere spelers kunnen de gekozen naam zien)";
                }
            }
            else if (placement < 10)
            {
                pnlHighscore.Show();

                lowestScore(10);
                 
                if (placement > 1)
                {
                    lblHighScoreInfo.Text = "NEW HIGHSCORE, u bent " + placement.ToString() + "e geplaatst" + "\r\n" + "vul hieronder uw naam in" + "\r\n" + "(waarschuwing: andere spelers kunnen de gekozen naam zien)";
                }
                else
                {
                    lblHighScoreInfo.Text = "NEW HIGHSCORE, u bent " + placement.ToString() + "st geplaatst" + "\r\n" + "vul hieronder uw naam in" + "\r\n" + "(waarschuwing: andere spelers kunnen de gekozen naam zien)";
                }
            }

        }
        private void InitializeDatabaseConnection()
        {
            //database connectie maken
            string server = "localhost";
            string database = "highscores";
            string dbUsername = "root";
            string dbPassword = "";

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + dbUsername + ";" + "PASSWORD=" + dbPassword + ";";

            connection = new MySqlConnection(connectionString);
        }

        private bool OpenConnection()
        {

            CloseConnection();

            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
       
        // dit zorgt ervoor als de score een top 10 is dat waneer je een naam ingevuld hebt hij naar de database zal gaan met de playerscore
        private void sql()
        {
            OpenConnection();

            string insertQuerry = "INSERT INTO scores(Naam, Score) VALUES (@Naam, " + playerScore + ")";

            MySqlCommand cmd = new MySqlCommand(insertQuerry, connection);

            cmd.Parameters.Add("@Naam", MySqlDbType.VarChar, 25);
            cmd.Parameters["@Naam"].Value = txbNaam.Text;

            if (cmd.ExecuteNonQuery() == 1)
            {
                txbNaam.Text = "score opgeslagen" + "\r\n";

                pnlHighscore.Hide();
            }

            CloseConnection();


        }
        // dit zorg ervoor dat de 10de plek word verwijderd uit de database
        private void sqlDelete()
        {
            OpenConnection();
            if (placement == 10)
            {

                string deleteQuery = "/*DELETE FROM scores ORDER BY Score LIMIT 1*/";

                MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);

                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }
        // deze int kijkt welke plek je  ent geeindigd 
        private int lowestScore(int amount)
        {
            OpenConnection();

            string sqlQuery = "SELECT * FROM scores ORDER BY Score LIMIT " + amount;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();
               
                while (dataReader.Read())
                {
                    string localScore = dataReader["Score" + ""].ToString();

                    lowestPlayerScore = Convert.ToInt32(localScore);
                  
                    if (amount == 10)
                    {
                        if (lowestPlayerScore > playerScore)
                        {
                            placement++;
                        }
                    }
                }

                dataReader.Close();

                if (amount == 10)
                {
                    return placement;
                }
                else
                {
                    return lowestPlayerScore;
                }

                CloseConnection();
            }
            else
            {
                if (amount == 10)
                {
                    return placement;
                }
                else
                {
                    return lowestPlayerScore;
                }

                CloseConnection();
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            highscores scoreboard = new highscores();
            scoreboard.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            start hoofdpagina = new start();
                hoofdpagina.ShowDialog();
            
            Close();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            sql();

            sqlDelete();

            pnlHighscore.Hide();
        }

       
    }
}
