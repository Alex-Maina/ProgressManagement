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
    public partial class HomeForm : System.Windows.Forms.Form
    {
        private AdminFacade facade;
        private int Id;

        private UserModel[] users;
        public static ProjectModel[] projects;
        public static ProjectModel selectedProject;

        private CohortModel[] cohorts;
        public static CohortModel selectedCohort;
        
        public static AssignedProjectModel[] inprogressProjects;
        public static AssignedProjectModel selectedInprogress;

        public static AssignedProjectModel[] completedProjects; 
        public static AssignedProjectModel selectedCompleted;

        private TaskModel[] tasks;



        public HomeForm()
        {
            InitializeComponent();
            facade = new AdminFacade();
            Id = 0;
            DisplayProjects();
            DisplayCohorts();
        }

        private void projectsTabPage_Click(object sender, EventArgs e)
        {
            
        }
        //View btn event
        private void button2_Click(object sender, EventArgs e)
        {
            selectedProject = projects[projectsListBox.SelectedIndex];
            projectForm view = new();
            view.Show();
        }
        //Edit btn event
        private void button1_Click(object sender, EventArgs e)
        {
            selectedProject = projects[projectsListBox.SelectedIndex];
            editProjectForm edit = new();
            edit.Show();
            Close();
        }
        //Delete btn event
        private void button2_Click_1(object sender, EventArgs e)
        {
            selectedProject = projects[projectsListBox.SelectedIndex];
            deleteProjectForm delete = new();
            delete.Show();
            Close();
        }
        //Add new project
        private void addBtn_Click(object sender, EventArgs e)
        {
            addProjectForm add = new();
            add.Show();
            Close();
        }

        private void projectsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Display list of projects
        public void DisplayProjects()
        {
            projects = facade.GetListOfProjects();
            projectsListBox.DataSource = projects;
            projectsListBox.DisplayMember = "DisplayProject";
            projectsListBox.ValueMember = "ProjectID";
        }

        //Display details of selected project
        private void viewProject()
        {
            selectedProject = projects[projectsListBox.SelectedIndex];
            projectForm ob = new();
            ob.Show();
        }

        private void editAssignedBtn_Click(object sender, EventArgs e)
        {

        }

        private void addCohortBtn_Click(object sender, EventArgs e)
        {
            addCohortForm add = new();
            add.Show();
            Close();
        }

        private void cohortListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CohortDetails();
            InprogressProjects();
            CompleteProjects();
        }

        private void cohortTabPage_Selected(object sender, TabControlEventArgs e)
        {
            
        }


        //Display list of cohorts
        public void DisplayCohorts()
        {
            cohorts = facade.GetListOfCohorts();
            cohortListBox.DataSource = cohorts;
            cohortListBox.DisplayMember = "DisplayCohort";  
            cohortListBox.ValueMember = "CohortID";
        }
        //Get cohort details
        public void CohortDetails()
        {
            selectedCohort = cohorts[cohortListBox.SelectedIndex];
            cohortName.Text = selectedCohort.CohortName;
            startDate.Text = selectedCohort.StartDate;
        }
        //Get list of complete projects/Cohort
        public void InprogressProjects()
        {
            inprogressProjects = facade.GetListOfInprogressProjects(selectedCohort.CohortID);
            inprogressList.DataSource = inprogressProjects;
            inprogressList.DisplayMember = "Display";
            inprogressList.ValueMember = "AssignedProjectID";
        }
        //Get list of complete projects/Cohort
        public void CompleteProjects()
        {
            completedProjects = facade.GetListOfCompletedProjects(selectedCohort.CohortID);
            completedList.DataSource = completedProjects;
            completedList.DisplayMember = "Display";
            completedList.ValueMember = "AssignedProjectID";
        }


        private void HomeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void editCohortBtn_Click(object sender, EventArgs e)
        {
            selectedCohort = cohorts[cohortListBox.SelectedIndex];
            editCohortForm delete = new();
            delete.Show();
            Close();
        }

        private void deleteCohortBtn_Click(object sender, EventArgs e)
        {
            selectedCohort = cohorts[cohortListBox.SelectedIndex];
            deleteCohortForm delete = new();
            delete.Show();
            Close();
        }

        private void statusBtn_Click(object sender, EventArgs e)
        {
            selectedCohort = cohorts[cohortListBox.SelectedIndex];
            graduateCohortForm delete = new();
            delete.Show();
            Close();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            InprogressProjects();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
