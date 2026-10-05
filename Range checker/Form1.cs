using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_checker
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

        private void btncheck_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txtinteger.Text);
                if (number >= 1 && number <= 10)
                {
                    lblrangedecision.Text = "The number is within the range ";
                }
                else
                {
                    lblrangedecision.Text = "The number is outside the range ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtinteger.Clear();
            lblrangedecision.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
