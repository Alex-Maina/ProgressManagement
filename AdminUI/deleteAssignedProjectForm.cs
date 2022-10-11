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
    public partial class deleteAssignedProjectForm : Form
    {
        private AdminFacade facade;
        public deleteAssignedProjectForm()
        {
            InitializeComponent();
            facade = new AdminFacade();
        }

        private void deleteAssignedProjectForm_Load(object sender, EventArgs e)
        {
            Text = HomeForm.selectedCohort.CohortName;
            projectLabel.Text = "Are you sure you want to unassign "+HomeForm.selectedInprogress.ProjectName;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            Close();
        }

        private void unassignBtn_Click(object sender, EventArgs e)
        {
            facade.DeleteAssignedProject(HomeForm.selectedInprogress.AssignedProjectID);
            MessageBox.Show("Project Unassigned");
            Close();
        }
    }
}
