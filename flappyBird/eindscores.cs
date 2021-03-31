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
        private int highscore = 0;

        private int plaats = 1;

        private int laagsteScoreSpeler = 0;

        private MySqlConnection connection;

        public eindscores(int eindscore)
        {
            InitializeComponent();

            InitializeDatabaseConnection();
            
            pnlHighscore.Hide();

            highscore = eindscore;

            eindScoreText.Text = "Eind score:" + highscore.ToString();

            

            if (highscore > laagsteScoreSpeler)
            {
                pnlHighscore.Show();

                
            }

            

            
        }
        private void InitializeDatabaseConnection()
        {
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

        private void sql()
        {
            OpenConnection();

            string insertQuerry = "INSERT INTO highscores.scores(Naam, Score) VALUES (@Naam, " + highscore + ")";

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
        private void sqlDelete()
        {
            OpenConnection();

            string deleteQuery = "DELETE FROM highscores ORDER BY scores LIMIT 1";

            MySqlCommand cmd = new MySqlCommand(deleteQuery, connection);

            cmd.ExecuteNonQuery();

            CloseConnection();

        }

        private int laagsteScore()
        {
            OpenConnection();

            string sqlQuery = "SELECT * FROM highscores ORDER BY Score LIMIT ";

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
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            sql();

            sqlDelete();

            pnlHighscore.Hide();
        }
    }
}
