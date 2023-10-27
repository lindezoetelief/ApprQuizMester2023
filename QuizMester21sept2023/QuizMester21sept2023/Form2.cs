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

        //Forms
        Form1 loginForm = null;
        Form3 playForm = new Form3();
        //Form4 highscoreForm = new Form4();

        public Form2(Form1 c_loginForm)
        {
            InitializeComponent();
            loginForm = c_loginForm;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            databaseList = new List<Database>();
            databaseList.Add(new Database(tbxUsernameRegister.Text, tbxPasswordRegister.Text));

            foreach (Database item in databaseList)
            {
                item.GetRegister();

                if (item.RegisterLogin() == true)
                {
                    this.Hide();
                    playForm.Show();
                }
            }
        }

        private void btnGoToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }
    }
}
