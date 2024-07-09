using System;
using System.Windows.Forms;

namespace LoginFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            string username = userNameBox.Text;
            string password = passwordBox.Text;

            MessageBox.Show($"Username : {username}\nPassword : {password}");
        }

    }
}
