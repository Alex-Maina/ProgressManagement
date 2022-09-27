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
    public partial class editProjectForm : Form
    {
        private AdminFacade facade;
        int ID = HomeForm.selectedProject.ProjectID;

        public editProjectForm()
        {
            InitializeComponent();
            facade = new AdminFacade();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void editProjectForm_Load(object sender, EventArgs e)
        {
            Text = HomeForm.selectedProject.ProjectName;
            nameBox.Text = HomeForm.selectedProject.ProjectName;
            codeBox.Text = HomeForm.selectedProject.ProjectCode;
            durationBox.Text = HomeForm.selectedProject.ProjectDuration.ToString();
            levelBox.Text = HomeForm.selectedProject.Level;
            videoBox.Text = HomeForm.selectedProject.Link;
            repoBox.Text = HomeForm.selectedProject.Github;
            descriptionBox.Text = HomeForm.selectedProject.ProjectDescription;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //Reopen the updated window
            HomeForm home = new();
            home.Show();
            Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int duration;
                bool isParsable = Int32.TryParse(durationBox.Text, out duration);
                if (isParsable)
                {

                    facade.UpdateProject(
                                nameBox.Text,
                                descriptionBox.Text,
                                levelBox.Text,
                                duration,
                                repoBox.Text,
                                videoBox.Text,
                                ID
                           );

                    nameBox.Text = "";
                    codeBox.Text = "";
                    durationBox.Text = "";
                    levelBox.Text = "";
                    videoBox.Text = "";
                    repoBox.Text = "";
                    descriptionBox.Text = "";

                    MessageBox.Show("Project updated successfuly");

                    //Reopen the updated window
                    HomeForm home = new();
                    home.Show();
                    //Close this window
                    Close();
                }
                else
                    MessageBox.Show("Duration should be a number");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }
    }
}
