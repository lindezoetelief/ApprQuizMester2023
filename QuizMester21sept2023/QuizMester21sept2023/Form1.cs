﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMester21sept2023
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=QuizMesterDatabase;Integrated Security=True";

        bool executeOke = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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
                using (DataTable dt = new DataTable("Users"))
                {
                    using (SqlCommand cmd = new SqlCommand("Select * from Users where username = @username;", cn))
                    {
                        cmd.Parameters.AddWithValue("username", tbxUsername.Text);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);

                    }
                }
            }
            if (dt = !null)
            {
                executeOke = true;
            }
            return executeOke;
        }
    }
}
