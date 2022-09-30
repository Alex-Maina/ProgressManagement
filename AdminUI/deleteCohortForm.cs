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
    public partial class deleteCohortForm : Form
    {
        private AdminFacade facade;
        int id = HomeForm.selectedCohort.CohortID;
        public deleteCohortForm()
        {
            InitializeComponent();
            facade = new AdminFacade();
        }
        //cancel button
        private void button1_Click(object sender, EventArgs e)
        {
            //Reopen the updated window
            HomeForm home = new();
            home.Show();
            Close();
        }

        private void deleteCohortForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = HomeForm.selectedCohort.CohortName + " ?";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            facade.DeleteCohort(id);
            //Reopen the updated window
            HomeForm home = new();
            home.Show();
            MessageBox.Show("Cohort deleted successfuly");
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
