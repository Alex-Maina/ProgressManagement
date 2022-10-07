using PTSLibrary.Facades;
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
    public partial class deleteTeamleaderForm : Form
    {
        private AdminFacade facade;
        int id = 0;
        public deleteTeamleaderForm()
        {
            InitializeComponent();
            facade = new AdminFacade(); 
        }

        private void abortBtn_Click(object sender, EventArgs e)
        {
            HomeForm home = new();
            home.Show();
            Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            id = HomeForm.selectedTeamleader.ID;
            facade.demoteUserRole(id);
            MessageBox.Show("Teamleader removed successfuly");
            HomeForm home = new();
            home.Show();
            //Close this window
            Close();

        }

        private void deleteTeamleaderForm_Load(object sender, EventArgs e)
        {
            confirmMsg.Text = "Are you sure you want to remove " + HomeForm.selectedTeamleader.Username + " as a teamleader?";
        }
    }
}
