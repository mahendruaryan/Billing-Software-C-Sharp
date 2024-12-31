using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
            
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
             
            usernametxtbox.Text = User.Users[Loginpage.logineduserindex].UserName;//username textbox text will be username

        }

        private void chnpassbtn_Click(object sender, EventArgs e)
        {
            if (User.Users[Loginpage.logineduserindex].Password == currpasswordtxtbox.Text)
            {
                if(newpasstxtbox.Text == reentertxtbox.Text)
                {
                    User.Users[Loginpage.logineduserindex].Password = newpasstxtbox.Text;
                    MessageBox.Show("Password Changed");
                    User.SaveData(User.Users);
                    currpasswordtxtbox.Text = "";
                    newpasstxtbox.Text = "";
                    reentertxtbox.Text = "";
;                }
                else
                {
                    MessageBox.Show("Your new password and renenter password does not match");
                }
            }
            else if(newpasstxtbox.Text == "" || reentertxtbox.Text == "" || currpasswordtxtbox.Text == "")
            {
                MessageBox.Show("Please fill all the blanks");
            }
            else
            {
                MessageBox.Show("Your current password does not match with records");
            }




        }

        private void ChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }
}
