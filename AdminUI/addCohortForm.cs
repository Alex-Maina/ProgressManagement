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
    public partial class addCohortForm : Form
    {
        private AdminFacade facade;
        public addCohortForm()
        {
            InitializeComponent();
            facade = new AdminFacade();
        }

        private void addCohortBtn_Click(object sender, EventArgs e)
        {
            facade.CreateCohort(startDate.Value);

            MessageBox.Show("New cohort created successfuly");

            //Reopen the updated window
            HomeForm home = new();
            home.Show();
            //Close this window
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //Reopen the updated window
            HomeForm home = new();
            home.Show();
            Close();
        }
    }
}
