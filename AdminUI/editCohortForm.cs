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
    public partial class editCohortForm : Form
    {
        private AdminFacade facade;
        int id = HomeForm.selectedCohort.CohortID;

        public editCohortForm()
        {
            InitializeComponent();
            facade = new AdminFacade();
        }

        private void editCohortForm_Load(object sender, EventArgs e)
        {
            Text = HomeForm.selectedCohort.CohortName;
            cohortLabel.Text = "Are sure you want to adjust the start date for "+HomeForm.selectedCohort.CohortName;

            DateTime now = DateTime.Now;
            startDate.MinDate = now;
            startDate.Value = now;
        }

        private void editCohortBtn_Click(object sender, EventArgs e)
        {
            facade.editCohort(startDate.Value, id);

            MessageBox.Show("Date updated successfuly");

            //Reopen the updated window
            HomeForm home = new();
            home.Show();
            //Close this window
            Close();
        }

        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            //Reopen the updated window
            HomeForm home = new();
            home.Show();
            Close();
        }
    }
}
