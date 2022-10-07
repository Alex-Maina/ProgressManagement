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
    public partial class assignProjectForm : Form
    {
        private AdminFacade facade;
        private UserModel[] teamleaders;
        public static UserModel selectedTeamleader;
        public static ProjectModel[] projects;
        public static ProjectModel selectedProject;


        public assignProjectForm()
        {
            InitializeComponent();
            facade = new AdminFacade();
            DisplayProjects();
            DisplayTeamleaders();
        }

        private void assignProjectForm_Load(object sender, EventArgs e)
        {
            cohortLabel.Text = "Assign project to " + HomeForm.selectedCohort.CohortName;
        }

        //List of projects
        public void DisplayProjects()
        {
            projects = facade.GetListOfProjects();
            projectComboBox.DataSource = projects;
            projectComboBox.DisplayMember = "ProjectName";
            projectComboBox.ValueMember = "ProjectID";
        }

        //List of teamleaders
        public void DisplayTeamleaders()
        {
            teamleaders = facade.GetListOfTeamLeaders();
            teamleaderComboBox.DataSource = teamleaders;
            teamleaderComboBox.DisplayMember = "Username";
            teamleaderComboBox.ValueMember = "ID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cohortID;
            cohortID = HomeForm.selectedCohort.CohortID;
            int projectID = projects[projectComboBox.SelectedIndex].ProjectID;
            int tlID = teamleaders[teamleaderComboBox.SelectedIndex].ID;

            try
            {
                facade.AssignProject(
                     startDateBox.Value,
                     projectID,
                     cohortID,
                     tlID
                  );
                MessageBox.Show("Project added successfuly");
                Close();  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
