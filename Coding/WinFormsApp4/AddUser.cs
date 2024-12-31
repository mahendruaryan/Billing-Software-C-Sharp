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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void typecombobox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;//user will not able to edit the combobox
        }

        private void createbtn_Click(object sender, EventArgs e)
        {//checking if user has filled up all the blanks
            if(usernametxtbox.Text=="" || passwordtxtbox.Text == "" || confirmpasstxtbox.Text == "" || typecombobox.Text == "")
            {
                MessageBox.Show("Please fill all the blanks");
            }
            else if (User.UserCheck(usernametxtbox.Text))//checking if the same user exist with the user function
            {
                MessageBox.Show("This user already exist");
            }
            else if (passwordtxtbox.Text != confirmpasstxtbox.Text)//checking if Password and confirm password does not match
            {
                MessageBox.Show("Password and confirm password does not match");
            }
            else
            {
                if (typecombobox.Text == "Manager")
                {//registering with Manager Type
                    User.Users.Add(new User(usernametxtbox.Text, passwordtxtbox.Text, true));
                    MessageBox.Show(usernametxtbox.Text+" registered");
                    this.Hide();
                    new AddUser().Show();
                    User.SaveData(User.Users);
                }
                else
                {//registering with General Type
                    User.Users.Add(new User(usernametxtbox.Text, passwordtxtbox.Text, false));
                    MessageBox.Show(usernametxtbox.Text + " registered");
                    this.Hide();
                    new AddUser().Show();
                    User.SaveData(User.Users);
                }
            }
            
        }

        private void back_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();//dashboard will show 
            this.Hide();
        }
    }
}
