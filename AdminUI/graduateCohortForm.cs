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
    public partial class graduateCohortForm : Form
    {
        private AdminFacade facade;
        int id = HomeForm.selectedCohort.CohortID;

        public graduateCohortForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            facade.graduateCohort(id);
            //Reopen the updated window
            HomeForm home = new();
            home.Show();
            MessageBox.Show("Completion confirmed");
            Close();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Reopen the updated window
            HomeForm home = new();
            home.Show();
            Close();
        }

        private void graduateCohortForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = HomeForm.selectedCohort.CohortName;
        }
    }
}
