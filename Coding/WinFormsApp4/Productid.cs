using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Productid : Form
    {
        
        public Productid()
        {
            
            InitializeComponent();
            
        }

        private void Productid_Load(object sender, EventArgs e)
        {
            productsdatagid.DataSource = Product.items;
            this.MaximizeBox= false;
            
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in productsdatagid.Rows)
            {
                row.Selected = false;   // deselecting the row which already selected
            }
            try//will give error if text is empty
            {
                string text = searchtxbox.Text;
                string search = text.Substring(0, 1).ToUpper() + text.Substring(1);// keeping first letter capital so that user able to find with lower letter
                SearchInDataGrid(search);
            }
            catch
            {
                MessageBox.Show("Please enter something to search");
            }
        }

        private void SearchInDataGrid(string search)
        {
            foreach(DataGridViewRow row in productsdatagid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString().Contains(search))
                    {
                        row.Selected= true;
                    }
                }
            }
        }

        private void searchtxbox_Click(object sender, EventArgs e)
        {
            searchtxbox.Text = "";     //when click color will set to black and text will be empty
            searchtxbox.ForeColor = Color.Black;
        }

        private void searchtxbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productsdatagid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
