using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_1_TextChanged(object sender, EventArgs e)
        {
            if(txtB_1.TextLength > 0)
            {
                btnClose.Text = txtB_1.Text;
            }
        }

        private void chkButtonEnabled_Click(object sender, EventArgs e)
        {
            btnClose.Enabled = chkButton.Checked;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Details detailsFrom1 = new Details(txtB_1.Text);
            detailsFrom1.Show();

            Baza_szwalniaEntities db = new Baza_szwalniaEntities();
            
        }

       
    }
}
