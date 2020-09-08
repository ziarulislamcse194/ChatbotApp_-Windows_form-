using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatMessage
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                if (userTextBox.Text.Trim() == "zia" && passwordTextBox.Text.Trim() == "123")
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                }
            }
        }

        private bool CheckValidation()
        {
            if (userTextBox.Text == "")
            {
                MessageBox.Show("Please put user name!");
                return false;
            }

            if (passwordTextBox.Text== "")
            {
                MessageBox.Show("Please put pass word!");
                return false;
            }

            return true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
