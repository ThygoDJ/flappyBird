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
    public partial class highscores : Form
    {
        private MySqlConnection connection;

        private int plaats = 1;

        public highscores()
        {
            InitializeComponent();

            InitializeDatabaseConnection();

            listView1.Items.Clear();

            List<string>[] AllScores = GetAllScores();

            // alle gegevens worden in de listview geplaats
            for (int i = 0; i < AllScores[0].Count; i++)
            {
                ListViewItem newScoreItem = new ListViewItem(new string[]
                {
                    plaats.ToString(),
                    AllScores[0][i],
                    AllScores[1][i],
                    AllScores[2][i],
                   

                }) ;
                plaats++;
                listView1.Items.Add(newScoreItem );
            }
        }

        private void InitializeDatabaseConnection()
        {
            //database connectie
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
            //einde database connectie
        }

        public List<string>[] GetAllScores()
        {
            // dit haalt de gegevens op uit de database
            string sqlQuery = "SELECT * FROM scores ORDER BY Score DESC LIMIT 10";

            List<string>[] resultList = new List<string>[3];
            resultList[0] = new List<string>();
            resultList[1] = new List<string>();
            resultList[2] = new List<string>();
            


            if (this.OpenConnection() == true)
            {

                MySqlCommand cmd = new MySqlCommand(sqlQuery, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    resultList[0].Add(dataReader["Naam"] + "");
                    resultList[1].Add(dataReader["Score"] + "");
                    resultList[2].Add(dataReader["Datum/Tijd"] + "");
                }

                dataReader.Close();

                this.CloseConnection();

                return resultList;
            }
            else
            {
                return resultList;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}