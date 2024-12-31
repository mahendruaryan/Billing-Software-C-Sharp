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
    public partial class Viewmem : Form
    {
        public Viewmem()
        {
            InitializeComponent();
        }

        private void Viewmem_Load(object sender, EventArgs e)
        {
            memdatagid.DataSource = Membership.people;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in memdatagid.Rows)
            {
                row.Selected = false;   // deselecting the row which already selected
            }
            try//will give error if text is empty
            {
                string text = searchtxbox.Text;
                SearchInDataGrid(text);
            }
            catch
            {
                MessageBox.Show("Please enter something to search");
            }
        }

        private void SearchInDataGrid(string search)
        {
            foreach (DataGridViewRow row in memdatagid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString().Contains(search))
                    {
                        row.Selected = true;
                    }
                }
            }
        }

        private void searchtxbox_Click(object sender, EventArgs e)
        {
            searchtxbox.Text = "";     //when click color will set to black and text will be empty
            searchtxbox.ForeColor = Color.Black;
        }

        private void Viewmem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }
    }
}
