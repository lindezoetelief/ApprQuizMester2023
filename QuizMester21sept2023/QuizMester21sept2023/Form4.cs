using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuizMester21sept2023
{
    public partial class Form4 : Form
    {
        string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=QuizMesterDatabase;Integrated Security=True";

        DataTable dt = null;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            GetTop10Highscores();
        }

        private void GetTop10Highscores()
        {
            // Define the SQL query to select the top 10 scores and user IDs, sorted in descending order
            string query = "SELECT TOP 10 userID, score FROM QuizRankings ORDER BY score DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();

                        // Fill the DataTable with the results of the query
                        adapter.Fill(dataTable);

                        // Clear the existing content of the RichTextBox
                        rtbxHighscores.Clear();

                        // Iterate through the rows in the DataTable and append user IDs and scores with a rank to the RichTextBox
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            //Use DataTable
                            using (dt = new DataTable("Users"))
                            {
                                //Search for username to check if it already exist
                                using (SqlCommand cmd = new SqlCommand("SELECT * from Users where userID = @userID; ", connection))
                                {
                                    cmd.Parameters.AddWithValue("userID", dataTable.Rows[i]["userID"]);
                                    SqlDataAdapter adapter2 = new SqlDataAdapter(cmd);
                                    adapter2.Fill(dt);
                                }
                            }

                            string userID = dataTable.Rows[i]["userID"].ToString();
                            string username = (string)dt.Rows[0]["username"];
                            int score = (int)dataTable.Rows[i]["score"];
                            int rank = i + 1; // Rank starts from 1

                            rtbxHighscores.AppendText($"#{rank} Username: {username} Score: {score}\n");
                        }
                    }
                }
            }
        }


    }
}
