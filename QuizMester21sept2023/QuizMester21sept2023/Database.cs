using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuizMester21sept2023
{
    internal class Database
    {
        string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=QuizMesterDatabase;Integrated Security=True";

        private bool executeOke = false;
        public int UserID = 0;


        string username = "";
        string password = "";

        int maxNumber = 0;

        DataTable dt = null;

        public Database(string c_username, string c_password)
        {
            username = c_username;
            password = c_password;
        }


        public bool GetLogin()
        {
            executeOke = false;
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
                using (dt = new DataTable("Users"))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * from Users where username = @username AND password = @password;", cn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                }
            }
            if (dt.Rows.Count <= 0)
            {
                executeOke = false;
            }
            else
            {
                executeOke = true;
                UserID = (int)dt.Rows[0]["userID"];
            }
            return executeOke;
        }
        public int GetUserID()
        {
            return UserID;
        }

        public void GetRegister()
        {
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open ();
                }
                //Use DataTable
                using (dt = new DataTable("Users"))
                {
                    //Search for username to check if it already exist
                    using (SqlCommand cmd = new SqlCommand("SELECT * from Users where username = @username; ", cn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);
                    }
                }
            }
            //Check if the statement found something
            if (dt.Rows.Count <= 0)
            {
                executeOke = true;
            }
            else
            {
                executeOke = false;
            }

            if (executeOke == true)
            {
                //Open/ use new connection
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }

                    //Use Datatable
                    using (dt = new DataTable("Users"))
                    {
                        ////For a new Userid fisrt search for current maximum Userid
                        using (SqlCommand cmd = new SqlCommand("SELECT MAX(userID) FROM Users", cn))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                            //Get a new Userid
                            maxNumber = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                        }

                        //Use the new maxNumber as new Userid in an INSERT statement for the new player
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO Users(userID, username, password) VALUES (@userID, @username, @password)", cn))
                        {
                            cmd.Parameters.AddWithValue("userID", maxNumber);
                            cmd.Parameters.AddWithValue("username", username);
                            cmd.Parameters.AddWithValue("password", password);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                        }
                    }
                }
                UserID = maxNumber;
            }
            else
            {
                MessageBox.Show("Username already exist");
            }
        }

        // After account is created succesfully player is directed to the playform (executeOke == true)
        public bool RegisterLogin()
        {
            return executeOke;
        }
    }
}
