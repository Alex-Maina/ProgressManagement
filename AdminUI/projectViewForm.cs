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
    public partial class projectForm : System.Windows.Forms.Form
    {

        public projectForm()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void durationLabel_Click(object sender, EventArgs e)
        {

        }

        private void projectViewForm_Load(object sender, EventArgs e)
        {
            Text = HomeForm.selectedProject.ProjectName;
            nameLabel.Text = HomeForm.selectedProject.ProjectName;
            codeLabel.Text = HomeForm.selectedProject.ProjectCode;
            durationLabel.Text = HomeForm.selectedProject.ProjectDuration.ToString() + " weeks";
            levelLabel.Text = HomeForm.selectedProject.Level;
            videoLabel.Text = HomeForm.selectedProject.Link;
            githubLabel.Text = HomeForm.selectedProject.Github;
            descriptionBox.Text = HomeForm.selectedProject.ProjectDescription;
        }
    }
}
