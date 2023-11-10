using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMester21sept2023
{
    public partial class Form2 : Form
    {
        List<Database> databaseList = null;

        //Form
        Form1 loginForm = null;

        public Form2(Form1 c_loginForm)
        {
            InitializeComponent();
            loginForm = c_loginForm;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            databaseList = new List<Database>();
            databaseList.Add(new Database(tbxUsernameRegister.Text, tbxPasswordRegister.Text));

            // Check if username excist or not, if it doesn't make a new user and log in
            foreach (Database item in databaseList)
            {
                item.GetRegister();

                if (item.RegisterLogin() == true)
                {
                    this.Hide();
                    Form3 playForm = new Form3(item.GetUserID());
                    playForm.Show();
                }
            }
        }

        private void btnGoToLogin_Click(object sender, EventArgs e)
        {
            // Switch forms
            this.Hide();
            loginForm.Show();
        }
    }
}
