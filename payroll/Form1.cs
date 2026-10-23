using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace payroll_with_overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txthoursworker_TextChanged(object sender, EventArgs e)
        {

        }

        private void txthourlypayrate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblgrosspayresult_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare variables
                double hours, rate, grosspay;

                // Check if the entered values are valid numbers
                if (double.TryParse(txthoursworker.Text, out hours) &&
                    double.TryParse(txthourlypayrate.Text, out rate))
                {
                    // Calculate regular pay
                    if (hours <= 40)
                    {
                        grosspay = hours * rate;
                    }
                    // Calculate overtime pay
                    else
                    {
                        grosspay = (40 * rate) + ((hours - 40) * rate * 1.5);
                    }

                    // Display the gross pay
                    lblgrosspayresult.Text = grosspay.ToString("");
                }
                else
                {
                    MessageBox.Show("Please enter valid Hours Worked and Hourly Pay Rate");
                }
            }
            catch
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // Clear 
            txthoursworker.Clear();
            txthourlypayrate.Clear();

            lblgrosspayresult.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}