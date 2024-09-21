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

namespace btvn_buoi_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String lastname = txtLN.Text;
            String firstname = txtFN.Text;
            String phone = txtP.Text;

            ListViewItem item = new ListViewItem(lastname);
           
            item.SubItems.Add(firstname);
            item.SubItems.Add(phone);

            LView.Items.Add(item);

            txtLN.Clear();
            txtFN.Clear();
            txtP.Clear();
            txtLN.Focus();
   

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (LView.Items.Count > 0)
            {
            
                DialogResult x = MessageBox.Show("you want delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (x == DialogResult.Yes)
                {
                    
                    for (int i = LView.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        LView.Items.Remove(LView.SelectedItems[i]);
                    }
                }
            }
            else
            {
                MessageBox.Show("No info!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            String lastname = txtLN.Text;
            String firstname = txtFN.Text;
            String phone = txtP.Text;

            if (LView.SelectedItems.Count > 0)
            {
                DialogResult x = MessageBox.Show("you want repair?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (x == DialogResult.Yes)
                {
                    ListViewItem selectedItem = LView.SelectedItems[0];
                    if (!string.IsNullOrWhiteSpace(lastname))
                    {
                        selectedItem.Text = lastname;
                    }
                    if (!string.IsNullOrWhiteSpace(firstname) && selectedItem.SubItems.Count > 1)
                    {
                        selectedItem.SubItems[1].Text = firstname;
                    }
                    if (!string.IsNullOrWhiteSpace(phone) && selectedItem.SubItems.Count > 2)
                    {
                        selectedItem.SubItems[2].Text = phone;
                    }
                } 
            }
            txtLN.Clear();
            txtFN.Clear();
            txtP.Clear();
            txtLN.Focus();
        }
    }
}
