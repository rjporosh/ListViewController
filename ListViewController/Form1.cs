using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem p = new ListViewItem(txtName.Text);
            p.SubItems.Add(txtAge.Text);
            p.SubItems.Add(txtEmail.Text);
            listViewMail.Items.Add(p);
            txtName.Text = "";
            txtAge.Text = "";
            txtEmail.Text = "";

        }

        private void getNameOfItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewMail.SelectedItems.Count > 0)
            {
                MessageBox.Show(listViewMail.SelectedItems[0].SubItems[0].Text);
            }
        }

        private void getEmailAddressOfTheSelectedUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewMail.SelectedItems.Count > 0)
            {
                MessageBox.Show(listViewMail.SelectedItems[0].SubItems[2].Text);
            }
        }

        private void getTheAgeOfSelectedUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewMail.SelectedItems.Count > 0)
            {
                MessageBox.Show(listViewMail.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void detailsOfTheUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewMail.SelectedItems.Count > 0)
            {
                MessageBox.Show(listViewMail.SelectedItems[0].SubItems[0].Text+": " + listViewMail.SelectedItems[0].SubItems[1].Text +" Email :" +listViewMail.SelectedItems[0].SubItems[2].Text);
            }
        }
    }
}
