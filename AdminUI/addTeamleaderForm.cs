using PTSLibrary.Facades;
using PTSLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminUI
{
    public partial class addTeamleaderForm : Form
    {
        private AdminFacade facade;
        private UserModel[] users;
        public static UserModel selectedUser;

        int id = 0;

        public addTeamleaderForm()
        {
            InitializeComponent();
            facade = new AdminFacade();
            DisplayUsers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeForm home = new();
            home.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                selectedUser = users[userListBox.SelectedIndex];
                id = selectedUser.ID;
                facade.elevateUserRole(id);
                MessageBox.Show("Added teamleader successfuly");
                HomeForm home = new();
                home.Show();
                //Close this window
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //List users
        public void DisplayUsers()
        {
            users = facade.GetListOfUsers();
            userListBox.DataSource = users;
            userListBox.DisplayMember = "Username";
            userListBox.ValueMember = "ID";
        }
        //Get user details
        public void userDetails()
        {
            selectedUser = users[userListBox.SelectedIndex];
            id = selectedUser.ID;
        }
    }
}
