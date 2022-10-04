using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtAPickleSubtotal.Text = (
                    20.0m * Convert.ToDecimal(txtAPickle.Text)
                ).ToString("0.00");
            txtBagOfAirSubtotal.Text = (
                    5.0m * Convert.ToDecimal(txtBagOfAir.Text)
                ).ToString("0.00");
            txtPretaxTotal.Text = (
                Convert.ToDecimal(txtAPickleSubtotal.Text) + Convert.ToDecimal(txtBagOfAirSubtotal.Text)
                ).ToString("0.00");
            txtTax.Text = (
                    Convert.ToDecimal(txtPretaxTotal.Text) / 6.875m
                ).ToString("0.00");
            txtTotal.Text = (
                    Convert.ToDecimal(txtTax.Text) + Convert.ToDecimal(txtPretaxTotal.Text)
                ).ToString("0.00");
            btnClear.Focus();
        }

        private void txtPretaxTotal_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAPickle.Text = "0";
            txtBagOfAir.Text = "0";
            txtAPickleSubtotal.Text = "";
            txtBagOfAirSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtAPickle.Focus();
        }
    }
}
