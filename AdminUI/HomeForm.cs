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
    public partial class HomeForm : Form
    {
        private AdminFacade facade;
        private int Id;

        private UserModel[] users;
        private ProjectModel[] projects;
        private CohortModel[] cohort;
        private ProjectModel selectedProject;
        private TaskModel[] tasks;

        

        public HomeForm()
        {
            InitializeComponent();
            facade = new AdminFacade();
            Id = 0;
            DisplayProjects();
        }

        private void projectsTabPage_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayProjects()
        {
            projects = facade.GetListOfProjects();
            projectsListBox.DataSource = projects;
            projectsListBox.DisplayMember = "DisplayProject";
            projectsListBox.ValueMember = "ProjectCode";
        }

        private void projectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
