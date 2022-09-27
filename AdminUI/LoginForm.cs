using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTSLibrary.Facades;
using PTSLibrary.Models;

namespace AdminUI
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        private AdminFacade facade;
        private int Id;
        
        public LoginForm()
        {
            InitializeComponent();
            facade = new AdminFacade();
            Id = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Id = facade.Authenticate(emailTextBox.Text, pwdTextBox.Text);
                if (Id != 0)
                {
                    emailTextBox.Text = "";
                    pwdTextBox.Text = "";
                    MessageBox.Show("Successfully logged In");
                    HomeForm ob = new();
                    ob.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Incorrect login details");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pwdTextBok_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
