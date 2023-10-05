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

        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            databaseList = new List<Database>();
            databaseList.Add(new Database(tbxUsernameRegister.Text, tbxPasswordRegister.Text));

            foreach (Database item in databaseList)
            {
                item.GetRegister();
            }
        }
    }
}
