using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placeholder_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //txtDiscountAmount.Text =
            //(Convert.ToDecimal(txtsubtotal.Text)
            // *Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString("0.00");
            //txtTotal.Text =
            // (Convert.ToDecimal(txtsubtotal.Text)
            //- Convert.ToDecimal(txtDiscountAmount.Text)).ToString("0.00");

            decimal nerd = 100;
            decimal otherNerd = Convert.ToDecimal(txtsubtotal.Text);
            decimal theOtherNerd = Convert.ToDecimal(txtDiscountPercent.Text);
            decimal creativeName101 = (otherNerd * theOtherNerd) / nerd;
            decimal inefficientlyLongNameOnlyBeingLongForThePurposeOfBeingAnnoying = otherNerd - creativeName101;

            txtTotal.Text = inefficientlyLongNameOnlyBeingLongForThePurposeOfBeingAnnoying.ToString("0.00");
            txtDiscountAmount.Text = creativeName101.ToString("0.00");
                
                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
