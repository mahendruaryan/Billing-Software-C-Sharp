using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.Json;

namespace WinFormsApp4
{
    
    public partial class Billingpage : Form
    {
        //used Membership.people for membership from member class 
        //used Buying.shoppingcart for the products which person want to buy 
        //used Product.items for the presaved data 
        int indexformembership = 0;     //for checking if the member exist or not
        int indexforproduct = 0;        // for checking if the product exist with the given id or not 
        int y ;                    //for printing the price and quantity defining my y axis so i can increase it with loop late
        int totalprice = 0;            //for total price paid by the customer
        int productexisting = 0;//for checking if the same product exist in shopping cart ,if same product exist it will add to it
        public Billingpage()
        {

            InitializeComponent();
        }

        private void Billingpage_Load(object sender, EventArgs e)
        {
            this.MaximizeBox= false;//will not allow the user to maximize the box
            totaltxtbox.Enabled= false;//user will not able to edit totalprice textbox it will edited automatically with code
            custnametxtbox.Enabled= false;
            custgendertxtbox.Enabled = false;
            custmobiletxtbox.Enabled = false;
            memvaliditytxtbox.Enabled = false;
            pronametxtbox.Enabled = false;
            propricetxtbox.Enabled = false;
            proquantitytxtbox.Enabled = false;
            proidtxtbox.Enabled = false;
            formemberlbl.Hide();
            havproidlbl.Hide();            

        }
       
        

        private void memidfetchbtn_Click(object sender, EventArgs e)
        {
            foreach(Membership member in Membership.people)
            {
                
                if (member.Id == memidtxtbox.Text && member.Status == true) 
                {
                    custnametxtbox.Text = member.Fname+" "+member.Lname;
                    custgendertxtbox.Text = member.Gender;
                    custmobiletxtbox.Text=  member.Mobile;
                    memvaliditytxtbox.Text = member.Validity.ToString("yy-MM-dd");
                    proidtxtbox.Enabled = true;
                    proquantitytxtbox.Enabled = true;
                    memidtxtbox.Enabled = false;
                    indexformembership = 1;
                   
                }

                else if (member.Id == memidtxtbox.Text && DateTime.Now > member.Validity)
                {
                    indexformembership = 1;  //setting to 1 so that it dont give two error this one and no memebership found
                    MessageBox.Show("Membership expired " + member.Fname + " please renew it");
                }



            }

            if (indexformembership == 0 )
            {
                MessageBox.Show("No membership found please try again");
                memidtxtbox.Text= string.Empty;
            }
            indexformembership= 0;
        }

        private void proidfetchbtn_Click(object sender, EventArgs e)
        {
            if (custnametxtbox.Text == "")
            {
                MessageBox.Show("Please enter name to proceed");
            }
            else if (custgendertxtbox.Text == "")
            {
                MessageBox.Show("Please enter gender to proceed");
            }
            else if (custmobiletxtbox.Text == "")
            {
                MessageBox.Show("Please enter mobile to proceed");
            }
            else if (custmobiletxtbox.TextLength > 10)
            {
                MessageBox.Show("Phone number is greater than 10 digit");
            }
            else if (custmobiletxtbox.TextLength <10 )
            {
                MessageBox.Show("Phone number is less than 10 digit");
            }
            else if (proidtxtbox.Text == "")
            {
                MessageBox.Show("Please enter Product Id to proceed");
            }
            

            else {
                for (int i = 0; i < Product.items.Count; i++)
                {
                    if (Product.items[i].Id == proidtxtbox.Text)
                    {
                        pronametxtbox.Text = Product.items[i].Name;
                        propricetxtbox.Text = Product.items[i].Price;
                        indexforproduct = 1;
                    }
                }
                if (indexforproduct == 0)
                {
                   MessageBox.Show("No Product found");
                }

            }
            indexforproduct= 0;

            
        }


        private void addbtn_Click(object sender, EventArgs e)
        {
            if (custmobiletxtbox.TextLength > 10)
            {
                MessageBox.Show("Phone number is greater than 10 digit");
            }
            else if (custmobiletxtbox.TextLength < 10)
            {
                MessageBox.Show("Phone number is less than 10 digit");
            }
            else if (pronametxtbox.Text == "")
            {
                MessageBox.Show("Please Fetch the details first or enter it manually");
            }
            else if (propricetxtbox.Text == "")
            {
                MessageBox.Show("Please enter price");
            }
            else if (proquantitytxtbox.Text == "")
            {
                MessageBox.Show("Please enter quanity");
            }
            else if (proquantitytxtbox.Text == "0")
            {
                MessageBox.Show("Quantity cannot be zero");
            }
            else if (propricetxtbox.Text == "0")
            {
                MessageBox.Show("Price cannot be zero");
            }
            else if (custnametxtbox.Text == "")
            {
                MessageBox.Show("Please enter name to proceed");
            }
            else if (custgendertxtbox.Text == "")
            {
                MessageBox.Show("Please enter gender to proceed");
            }
            else if (custmobiletxtbox.Text == "")
            {
                MessageBox.Show("Please enter mobile to proceed");
            }


            else
            {
                string productname = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(pronametxtbox.Text);//changing the namw to title case
                foreach (Buying items in Buying.shoppingcart)
                {//if the same item is already present in list so it will add the quantity in the same item
                    if(items.Name == productname && items.Unitprice == Int32.Parse(propricetxtbox.Text))
                    {
                        items.Quantity += Int32.Parse(proquantitytxtbox.Text);//increasing the quantity
                        items.Price+= Int32.Parse(proquantitytxtbox.Text)*items.Unitprice;//changing the price
                        shopcartgridview.DataSource = null;
                        shopcartgridview.DataSource = Buying.shoppingcart;//reloading the shopping cart
                        totalprice += (Int32.Parse(proquantitytxtbox.Text) * Int32.Parse(propricetxtbox.Text));
                        string strtotalprice=Convert.ToString(totalprice);
                        totaltxtbox.Text = (strtotalprice);
                        productexisting = 1;
                        proidtxtbox.Text = "";
                        pronametxtbox.Text = "";
                        propricetxtbox.Text = "";
                        proquantitytxtbox.Text = "";
                        MessageBox.Show("Added");
                    }
                }
                if (productexisting == 0)
                {
                    if (Buying.shoppingcart.Count >= 20)
                    {
                        MessageBox.Show("Maximum 20 products can be added at a time");
                    }
                    else
                    {
                        totalprice += (Int32.Parse(proquantitytxtbox.Text) * Int32.Parse(propricetxtbox.Text));
                        string ttotalprice = Convert.ToString(totalprice);//to show the price in textbox
                        Buying.shoppingcart.Add(new Buying(productname, Int32.Parse(propricetxtbox.Text), Int32.Parse(proquantitytxtbox.Text), Int32.Parse(proquantitytxtbox.Text) * Int32.Parse(propricetxtbox.Text)));
                        MessageBox.Show("Added");
                        proidtxtbox.Text = "";
                        pronametxtbox.Text = "";
                        propricetxtbox.Text = "";
                        proquantitytxtbox.Text = "";
                        shopcartgridview.DataSource = null;
                        shopcartgridview.DataSource = Buying.shoppingcart;
                        indexforproduct = 0;
                        totaltxtbox.Text = (ttotalprice);
                    }     
                }
                productexisting = 0;//making it ready for next time use
            }
            
        }

        private void delitembtn_Click(object sender, EventArgs e)
        {
            try
            {
                string delprices= shopcartgridview.CurrentRow.Cells[3].Value.ToString();   //Selecting the item to delete
                int delprice = Convert.ToInt32(delprices);
                totalprice = totalprice - delprice;                   //subracting delted item price from total price
                string ttotalprice = Convert.ToString(totalprice);
                totaltxtbox.Text = (ttotalprice);

                try
                {
                    Buying.shoppingcart.RemoveAt(shopcartgridview.SelectedRows[0].Index);
                }
                catch
                {
                    MessageBox.Show("Please select the whole row");
                    string revertprices = shopcartgridview.CurrentRow.Cells[3].Value.ToString();
                    int revertprice = Convert.ToInt32(revertprices);        // Adding price again if the grid gives error
                    totalprice = totalprice + revertprice;
                    string pricetobeadd = Convert.ToString(totalprice);
                    totaltxtbox.Text = (pricetobeadd);
                }
            }
            catch
            {
                MessageBox.Show("Please Add item before deleting");
            }
            
           
        }

        private void notamemlbl_Click(object sender, EventArgs e)
        {
            if (custnametxtbox.Text != "") {
                MessageBox.Show("Member is already fetched");
            
            }
            else
            {
                memidtxtbox.Text = "";
                memidtxtbox.Enabled = false;
                custnametxtbox.Enabled = true;
                custgendertxtbox.Enabled = true;
                custmobiletxtbox.Enabled = true;
                notamemlbl.Hide();
                formemberlbl.Show();
                proidtxtbox.Enabled = true;
                proquantitytxtbox.Enabled = true;
                Buying.shoppingcart.Clear();
                shopcartgridview.DataSource = null;
                
            }
            

        }

        private void formemberlbl_Click(object sender, EventArgs e)
        {
            custmobiletxtbox.Enabled = false;
            proidtxtbox.Enabled = false;
            proquantitytxtbox.Enabled = false;
            memidtxtbox.Enabled = true;
            custnametxtbox.Enabled = false;
            custgendertxtbox.Enabled = false;
            memvaliditytxtbox.Enabled = false;
            custnametxtbox.Text = "";
            custgendertxtbox.Text = "";
            memvaliditytxtbox.Text = "";
            custmobiletxtbox.Text = "";
            formemberlbl.Hide();
            notamemlbl.Show();
            Buying.shoppingcart.Clear();
            shopcartgridview.DataSource = null;
            
        }

        private void signoutbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Loginpage().Show();
            

        }

        private void noproidlbl_Click(object sender, EventArgs e)
        {
            if (custnametxtbox.Text == "" )
            {
                MessageBox.Show("Please enter name to proceed");
            }
            else if (custgendertxtbox.Text == "")
            {
                MessageBox.Show("Please enter gender to proceed");
            }
            else if (custmobiletxtbox.Text == "")
            {
                MessageBox.Show("Please enter mobile to proceed");
            }
            else 
            {
                proidtxtbox.Text = "";
                pronametxtbox.Text = "";
                propricetxtbox.Text = "";
                proquantitytxtbox.Text = "";
                proidtxtbox.Enabled = false;
                pronametxtbox.Enabled = true;
                propricetxtbox.Enabled = true;
                proquantitytxtbox.Enabled = true;
                noproidlbl.Hide();
                havproidlbl.Show();

            }
            
        }

        private void havproidlbl_Click(object sender, EventArgs e)
        {
            proidtxtbox.Text = "";
            pronametxtbox.Text = "";
            propricetxtbox.Text = "";
            proquantitytxtbox.Text = "";
            proidtxtbox.Enabled = true;
            pronametxtbox.Enabled = false;
            propricetxtbox.Enabled = false;
            noproidlbl.Show();
            havproidlbl.Hide();
        }

        private void newcustomerbtn_Click_1(object sender, EventArgs e)
        {
            
            this.Hide();
            new Billingpage().Show();
        }


        private void custmobiletxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Phone number cannot be characters");
            } 
        }

        private void propricetxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Price cannot be characters");
            }
        }

        private void proquantitytxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Quantity cannot be characters");
            }
        }

        private void Billingpage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
        private void printbtn_Click(object sender, EventArgs e)
        {
            if (Buying.shoppingcart.Count == 0)
            {
                MessageBox.Show("Please add atleast 1 item to shopping cart to proceed");
            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            y = 380;  //value of y set to default otheriwse items will go down each time print button pressed
            e.Graphics.DrawString("SHOPPING ENTERPRISE", new Font("Arial", 20), Brushes.Black, new Point(200, 100));
            e.Graphics.DrawString("CUSTOMER NAME:" + custnametxtbox.Text,new Font("Arial",11),Brushes.Black,new Point(25,200));
            e.Graphics.DrawString("CUSTOMER MOBILE:" + custmobiletxtbox.Text, new Font("Arial", 11), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString("GENDER:" + custgendertxtbox.Text, new Font("Arial", 11), Brushes.Black, new Point(25, 300));
            if (memidtxtbox.Enabled == false )
            {
                e.Graphics.DrawString("MEMBERSHIP ID:" + memidtxtbox.Text, new Font("Arial", 11), Brushes.Black, new Point(550, 250));
                e.Graphics.DrawString("MEMBERSHIP VALIDITY:" + memvaliditytxtbox.Text, new Font("Arial", 11), Brushes.Black, new Point(550, 300));
            }
            else
            {
                e.Graphics.DrawString("MEMBERSHIP ID:", new Font("Arial", 11), Brushes.Black, new Point(550, 250));
                e.Graphics.DrawString("MEMBERSHIP VALIDITY:", new Font("Arial", 11), Brushes.Black, new Point(550, 300));
            }
           
            e.Graphics.DrawString("DATE:" + DateTime.Now, new Font("Arial", 11), Brushes.Black, new Point(550, 200));
            e.Graphics.DrawString("PRODUCTS" , new Font("Arial", 11,FontStyle.Bold), Brushes.Black, new Point(25, 375));
            e.Graphics.DrawString("UNIT PRICE", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(250, 375));
            e.Graphics.DrawString("QUANTITY", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(475, 375));
            e.Graphics.DrawString("PRICE", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(700, 375));
            foreach (Buying buying in Buying.shoppingcart)
            {
               y = y + 30;
               e.Graphics.DrawString(buying.Name, new Font("Arial", 12), Brushes.Black, new Point(25, y));
               e.Graphics.DrawString("$" + Convert.ToString(buying.Unitprice), new Font("Arial", 12), Brushes.Black, new Point(250, y));
               e.Graphics.DrawString(Convert.ToString(buying.Quantity), new Font("Arial", 12), Brushes.Black, new Point(475, y));
               e.Graphics.DrawString("$" + Convert.ToString(buying.Price), new Font("Arial", 12), Brushes.Black, new Point(700, y));
                
            }
            e.Graphics.DrawString("TOTAL PRICE:", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(600, 1050));
            e.Graphics.DrawString(totaltxtbox.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(720, 1050));


        }

        private void searchprolbl_Click(object sender, EventArgs e)
        {
            Productid frm= new Productid();
            frm.ShowDialog();
            
        }

        private void proquantitytxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }
    }
}




