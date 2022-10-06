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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AdminUI
{
    public partial class createTeamleaderForm : Form
    {
        private AdminFacade facade;

        public createTeamleaderForm()
        {
            InitializeComponent();
            facade = new AdminFacade();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomeForm home = new();
            home.Show();
            //Close this window
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                facade.CreateTeamleader(
                    fname.Text,
                    lname.Text,
                    phone.Text,
                    email.Text
                 );
                fname.Text = "";
                lname.Text = "";
                phone.Text = "";
                email.Text = "";
                
                MessageBox.Show("Teamleader created successfuly");
                HomeForm home = new();
                home.Show();
                //Close this window
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
