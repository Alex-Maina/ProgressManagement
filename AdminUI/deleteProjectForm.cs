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
    public partial class deleteProjectForm : Form
    {
        private AdminFacade facade;
        int ID = HomeForm.selectedProject.ProjectID;

        public deleteProjectForm()
        {
            InitializeComponent();
            facade = new AdminFacade();
        }

        private void deleteProjectForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = HomeForm.selectedProject.ProjectName+" ?";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            facade.DeleteProject(ID);
            //Reopen the updated window
            HomeForm home = new();
            home.Show();
            MessageBox.Show("Project deleted successfuly");
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Reopen the updated window
            HomeForm home = new();
            home.Show();
            Close();
        }
    }
}
