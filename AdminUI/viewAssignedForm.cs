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
    public partial class viewAssignedForm : Form
    {
        private AdminFacade facade;
        public viewAssignedForm()
        {
            InitializeComponent();
            facade = new AdminFacade();
        }

        private void viewAssignedForm_Load(object sender, EventArgs e)
        {
            projectNameLabel.Text = HomeForm.selectedInprogress.ProjectName;
            startDateLabel.Text = HomeForm.selectedInprogress.StartDate;
            codeLabel.Text = HomeForm.selectedInprogress.ProjectCode;
            levelLabel.Text = HomeForm.selectedInprogress.Level;
        }
    }
}
