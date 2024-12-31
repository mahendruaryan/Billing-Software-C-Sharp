using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp4
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }



        private void propricextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Price cannot be characters");
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            int proindex = 0;//for checking if the same product name already exist or user didn't enter name or price
            string ProID = Product.NextProductID(Product.items);//function to genrate next product id
            string ProName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(pronametxtbox.Text);//changing the name to title case format
            for (int i = 0; i < Product.items.Count; i++)
            {
                if (Product.items[i].Name == ProName)
                {
                    MessageBox.Show("This item already exist");
                    proindex = 1;
                }
            }
            if (pronametxtbox.Text == "")
            {
                MessageBox.Show("Please Enter Product Name to proceed");
                proindex = 1;
            }
            if (propricextbox.Text == "")
            {
                MessageBox.Show("Please Enter Product Price to proceed");
                proindex = 1;
            }

            if (proindex == 0)
            {
                Product.items.Add(new Product(ProID,ProName,propricextbox.Text));
                MessageBox.Show(ProName+" Successfuly added with Product ID "+ProID);
                Product.SaveData(Product.items);
            }
        }

        private void AddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            Product.SaveData(Product.items);
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            this.MaximizeBox= false;
        }
    }
}
