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

namespace flappy_bird
{
    public partial class highscores : Form
    {

        private MySqlConnection connection;

        private int placement = 1;

        public highscores(int highscore)
        {
            InitializeComponent();

            InitializeDatabaseConnection();

            lblNaam.Text = "";
            lblScore.Text = "";

            string sqlQuery = "SELECT * FROM highscore ORDER BY highscore DESC LIMIT 10";

            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    lblNaam.Text = lblNaam.Text + "plaats: " + placement + dataReader["name"] + "\n\r";
                    lblScore.Text = lblScore.Text + " score: " + dataReader["score"] + "\n\r";
                    placement++;
                }

                dataReader.Close();

                this.CloseConnection();

            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            Close();
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

       
    }
}
        
    
