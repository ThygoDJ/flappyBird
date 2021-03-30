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
        private MySqlConnection connection;

        private int eindScore = 0;

        private int plaats = 1;

        private int laagsteScore = 0;

        public eindscores(int highscore)
        {
            InitializeComponent();

            InitializeDatabaseConnection();
            
            pnlHighscore.Hide();

            highscore = eindScore;

            eindScoreText.Text = "Eind score:" + highscore.ToString();

            if (highscore > laagsteScore)
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




        private void pictureBox11_Click(object sender, EventArgs e)
        {
            highscores scoreboard = new highscores();
            scoreboard.ShowDialog();
        }
    }
}
