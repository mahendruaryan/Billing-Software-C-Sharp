using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp4
{
    public partial class Memberreg : Form
    {
        int memberfoundcheck = 0;//for checking if the member exist with the membership ID while renewing
        int memberindex;//for renewing membership saving the index number here
        public Memberreg()
        {
            InitializeComponent();
            
        }

        private void newmemcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (newmemcheckbox.Checked == true)      //checking if new member check box is checked or not
            {
                memidtxtbox.Enabled= false;  //if it is new member ,mem id will be txtbox btn lbl will disabled
                memidlbl.Enabled= false;
                fetchbtn.Enabled= false;
                renewmemcheckbox.Enabled = false;   //disabling renew member check box if new member is checked
            }
            else
            {
                renewmemcheckbox.Enabled = true;   //enabling if it is unchecked
            }
        }

        private void renewmemcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (renewmemcheckbox.Checked == true) //checking if renew member check box is checked or not
            {
                fetchbtn.Enabled= true;// enabling mem id txtbox and label
                memidlbl.Enabled= true;
                memidtxtbox.Enabled= true;
                newmemcheckbox.Enabled = false; //disabling new member check box if new member is checked
            }
            else
            {
                fetchbtn.Enabled= false;  //disabling and clearing textbox and button if checked box is unticked
                memidlbl.Enabled = false;
                memidtxtbox.Enabled = false;
                memidtxtbox.Text = "";
                newmemcheckbox.Enabled = true;//enabling if it is unchecked
            }

        }

        private void Memberreg_Load(object sender, EventArgs e)
        {
            mempricetxtbox.Enabled= false;//disabling the textbox so that no one can change text
            mempricetxtbox.Text = "$90";//setting membership price
            fetchbtn.Enabled = false; // when form will load this all buttons will be dissabled
            memidlbl.Enabled = false;
            memidtxtbox.Enabled = false;
        }
        
        private void fetchbtn_Click(object sender, EventArgs e)
        {
            memberfoundcheck = 0;//when button will press this will set to zero
            for(int a=0;a<Membership.people.Count;a++)
            {
                if(memidtxtbox.Text == Membership.people[a].Id)
                {
                    memberindex = a; 
                    fnametxtbox.Text = Membership.people[a].Fname;
                    lnametxtbox.Text = Membership.people[a].Lname;
                    dobdatetime.Value = Membership.people[a].Dob;
                    gentxtbox.Text = Membership.people[a].Gender;
                    mobtxtbox.Text = Membership.people[a].Mobile;
                    emailtxtbox.Text = Membership.people[a].Email;
                    streettxtbox.Text = Membership.people[a].Streetaddress;
                    citytxtbox.Text = Membership.people[a].City;
                    provincetxtbox.Text = Membership.people[a].Province;
                    countrytxtbox.Text = Membership.people[a].Country;
                    postalcodetxtbox.Text = Membership.people[a].Postalcode;
                    memberfoundcheck = 1;// if member is found this will set to 1
                    MessageBox.Show("Please Check the details and change if required");

                }
            }

            if(memberfoundcheck == 0)
            {
                MessageBox.Show("Please Try Again No Member found with this Membership ID ");
            }
        }

        private void cashcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(cashcheckbox.Checked== true)// checking if cash check box is checked or not
            {
                cardcheckbox.Enabled= false;//if cash check box is checked card checkbox disabled
            }
            else
            {
                cardcheckbox.Enabled= true;  //enabling if it is unselected
            }
        }

        private void cardcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(cardcheckbox.Checked== true)// checking if cash check box is checked or not
            {
                cashcheckbox.Enabled= false;//if card check box is checked card checkbox disabled
            }
            else
            {
                cashcheckbox.Enabled= true;
            }
        }

        private void Memberreg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {

            if (newmemcheckbox.Checked == true)
            {
                DateTime memvalidity = DateTime.Now.AddYears(1);//genrating memvalidity for 1 year
                string newmemid = Membership.NextMem(Membership.people);//getting new mem id from nextmem function
                TimeSpan diffrence = DateTime.Now - dobdatetime.Value;//for checking age of customer
                string firstname= System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(fnametxtbox.Text);
                string lastname = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(lnametxtbox.Text);
                string gender = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(gentxtbox.Text);
                string streetaddress = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(streettxtbox.Text);
                string city = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(citytxtbox.Text);
                string province = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(provincetxtbox.Text);
                string country = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(countrytxtbox.Text);
                string postalcode = postalcodetxtbox.Text.ToUpper();


                //all the possible testbox that user can left empty
                if (fnametxtbox.Text == "" || lnametxtbox.Text == "" || gentxtbox.Text == "" || mobtxtbox.Text == "" || emailtxtbox.Text == "" || streettxtbox.Text == "" || citytxtbox.Text == "" || provincetxtbox.Text == "" || countrytxtbox.Text == "" || postalcodetxtbox.Text == "")
                {
                    MessageBox.Show("Please fill all the blanks");

                }
                else if (diffrence.TotalDays < 365 * 16)//checking if the customer is over 16 or not
                {
                    MessageBox.Show("You must be 16 to be eligible");
                }
                else if (mobtxtbox.TextLength > 10)// if user enter more than 10 digit mobile number
                {
                    MessageBox.Show("Mobile number cannot be over 10 digits");
                }
                else if (mobtxtbox.TextLength < 10)// if user enter less than 10 digit mobile number
                {
                    MessageBox.Show("Mobile number cannot be less than 10 digits");
                }
                else if (Membership.MemberCheck(Membership.people, mobtxtbox.Text))//function to check if the phone number already exist
                {
                    MessageBox.Show("Membership with this number already exist");
                }
                else if(cashcheckbox.Checked == false && cardcheckbox.Checked== false)
                {
                    MessageBox.Show("Please Select Cash or Card");
                }
                else
                {
                    Membership.people.Add(new Membership(newmemid, firstname, lastname, dobdatetime.Value, gender, mobtxtbox.Text, emailtxtbox.Text, streetaddress, city,province, country, postalcode, memvalidity));
                    MessageBox.Show(firstname + " " + lastname + " have been succesfully registered for 1 year with the following membership ID" + newmemid);
                    Membership.SaveData(Membership.people);
                    this.Hide();//resetting the page to clear
                    new Memberreg().Show();
                }
            }

            else if (renewmemcheckbox.Checked == true)
            {
                TimeSpan renewaldiffrence = DateTime.Now - dobdatetime.Value;//for checking age of customer
                if (memberfoundcheck == 1)
                {
                    if (fnametxtbox.Text == "" || lnametxtbox.Text == "" || gentxtbox.Text == "" || mobtxtbox.Text == "" || emailtxtbox.Text == "" || streettxtbox.Text == "" || citytxtbox.Text == "" || provincetxtbox.Text == "" || countrytxtbox.Text == "" || postalcodetxtbox.Text == "")
                    {
                        MessageBox.Show("Please fill all the blanks");

                    }
                    else if (renewaldiffrence.TotalDays < 365 * 16)//checking if the customer is over 16 or not
                    {
                        MessageBox.Show("You must be 16 to be eligible");
                    }
                    else if (mobtxtbox.TextLength > 10)// if user enter more than 10 digit mobile number
                    {
                        MessageBox.Show("Mobile number cannot be over 10 digits");
                    }
                    else if (mobtxtbox.TextLength < 10)// if user enter less than 10 digit mobile number
                    {
                        MessageBox.Show("Mobile number cannot be less than 10 digits");
                    }
                    else if (cashcheckbox.Checked == false && cardcheckbox.Checked == false)
                    {
                        MessageBox.Show("Please Select Cash or Card");
                    }
                    else
                    {
                        DateTime memvalidityrenewal = DateTime.Now.AddYears(1);//genrating memvalidity for 1 year
                        Membership.people[memberindex].Fname = fnametxtbox.Text;
                        Membership.people[memberindex].Lname = lnametxtbox.Text;
                        Membership.people[memberindex].Dob = dobdatetime.Value;
                        Membership.people[memberindex].Gender = gentxtbox.Text;
                        Membership.people[memberindex].Mobile = mobtxtbox.Text;
                        Membership.people[memberindex].Email = emailtxtbox.Text;
                        Membership.people[memberindex].Streetaddress = streettxtbox.Text;
                        Membership.people[memberindex].City = citytxtbox.Text;
                        Membership.people[memberindex].Province = provincetxtbox.Text;
                        Membership.people[memberindex].Country = countrytxtbox.Text;
                        Membership.people[memberindex].Postalcode = postalcodetxtbox.Text;
                        Membership.people[memberindex].Validity = memvalidityrenewal;
                        Membership.people[memberindex].Status = true;
                        MessageBox.Show(Membership.people[memberindex].Fname + " " + "Membership ID" + " " + Membership.people[memberindex].Id + " " + "Successfully Renewed for 1 year");
                        Membership.SaveData(Membership.people);
                        this.Hide();//resetting the page to clear
                        new Memberreg().Show();
                    }  
                }
                else
                {
                    MessageBox.Show("Please Enter correct Membership ID");
                }

            }

            else
            {
                MessageBox.Show("Please select new or renew membership");
            }
        }

        private void mobtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))//if user enter more than alphabets rather than digits
            {
                e.Handled = true;
                MessageBox.Show("Mobile number cannot be characters");
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        private void mempricetxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
