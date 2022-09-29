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
        public editCohortForm()
        {
            InitializeComponent();
        }

        private void editCohortForm_Load(object sender, EventArgs e)
        {
            Text = HomeForm.selectedCohort.CohortName;
            cohortLabel.Text = "Are sure you want to adjust the start date for "+HomeForm.selectedCohort.CohortName;
        }

        private void editCohortBtn_Click(object sender, EventArgs e)
        {

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
