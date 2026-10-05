using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIP_TAX_TOTAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Txtfood_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            try
            {
                // Variables
                string food1, food2;
                int price1, price2;
                double salesTax, total;

                // Input
                food1 = Txtfood.Text;
                price1 = int.Parse(txtprice.Text);

                food2 = txtfood2.Text;
                price2 = int.Parse(txtprice2.Text);

                // Calculate Sales Tax
                salesTax = (price1 + price2) * 0.07;

                // Calculate Total
                total = price1 + price2 + salesTax;

                // Output
                lbltotalsales.Text = " $ " + salesTax.ToString("");
                lbltotal.Text = " $ " + total.ToString("");
            }
            catch
            {
                MessageBox.Show("Please enter valid food and price.");
            }
        }
        

        private void lbltotalsales_Click(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfood2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprice2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
