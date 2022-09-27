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
    public partial class addProjectForm : Form
    {
        private AdminFacade facade;
        
        public addProjectForm()
        {
            InitializeComponent();
            facade = new AdminFacade();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int duration;
                bool isParsable = Int32.TryParse(durationBox.Text, out duration);
                if (isParsable)
                {
                    facade.CreateProject(
                                nameBox.Text,
                                descriptionBox.Text,
                                levelBox.Text,
                                duration,
                                repoBox.Text,
                                videoBox.Text
                           );

                    nameBox.Text = "";
                    durationBox.Text = "";
                    levelBox.Text = "";
                    videoBox.Text = "";
                    repoBox.Text = "";
                    descriptionBox.Text = "";

                    MessageBox.Show("Project added successfuly");

                    //Reopen the updated window
                    HomeForm home = new();
                    home.Show();
                    //Close this window
                    Close();
                }
                else
                    MessageBox.Show("Duration should be a number");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //Reopen the updated window
            HomeForm home = new();
            home.Show();
            Close();
        }

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
