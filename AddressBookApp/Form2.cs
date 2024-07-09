using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBookApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameField.Text;
            string email = emailField.Text;
            string phoneNumber = phoneNumberField.Text;

            List<String> address = new List<string> { name, email, phoneNumber };   // Store details in address list

            List<List<String>> addressBook = new List<List<String>>();   
            addressBook.Add(address); 
            address.Clear();  

            MessageBox.Show($"User Details: {name}, {email}, {phoneNumber}\nSaved contact successfully.");

        }
    }
}