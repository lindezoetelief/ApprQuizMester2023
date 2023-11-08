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
           
        }

        private void GetTop10Highscores()
        {
            /// Search the database for the given credentials
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                // Check if there is a database connection open
                if (cn.State == ConnectionState.Closed)
                {
                    // Open a database connection if one cannot be found
                    cn.Open();
                }

                // Datatable with the name dt checking for users
                using (dt = new DataTable("QuizRankings"))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT TOP 10 Username, Score FROM Leaderboard ORDER BY Score DESC"))
                    {
                        //cmd.Parameters.AddWithValue("username", username);
                        //cmd.Parameters.AddWithValue("password", password);
                        //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        //adapter.Fill(dt);

                    }
                }
            }
        }
    }
}
