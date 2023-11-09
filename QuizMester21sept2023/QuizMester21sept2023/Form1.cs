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
    public partial class Form1 : Form
    {

        List<Database> databaseList = null;

        //Form
        Form2 registerForm = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            registerForm = new Form2(this);
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            databaseList = new List<Database>();
            databaseList.Add(new Database(tbxUsername.Text, tbxPassword.Text));

            // Search in class database.cs if user credentials are correct
            foreach (Database item in databaseList)
            {
                if (item.GetLogin() == true)
                {
                    this.Hide();
                    Form3 playForm = new Form3(item.GetUserID());
                    playForm.Show();
                }
                else
                {
                    MessageBox.Show("Loggin failed, try again or register");
                }
            }
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            // Switch Forms
            this.Hide();
            registerForm.Show();
        }
    }
}
