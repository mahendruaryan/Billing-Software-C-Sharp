using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        //different forms will open in this page according to user preference
        private void billingbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Billingpage().Show();
        }

        private void addmembtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Memberreg().Show();
        }

        private void addprobtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddProduct().Show();    
        }

        private void viewprobtn_Click(object sender, EventArgs e)
        {
            new Productid().Show();
        }


        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void memviewbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Viewmem().Show();
        }

        private void chnpassbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePassword().Show();
        }

        private void managerbtn_Click(object sender, EventArgs e)
        {
            if (User.Users[Loginpage.logineduserindex].Manager)
            {
                new AddUser().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You must be a Manager to register a user");
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void signoutbtn_Click(object sender, EventArgs e)
        {
            new Loginpage().Show();
            this.Hide();
        }
    }
}
