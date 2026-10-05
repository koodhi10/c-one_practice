using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btncalculate_Click(object sender, EventArgs e)
        {
            // variables scores and average
            double score1, score2, score3, average;

            try
            {
                // Convert Test Scores from text to a double value
                if (double.TryParse(txtscore1.Text, out score1))
                {
                    if (double.TryParse(txtscore2.Text, out score2))
                    {
                        if (double.TryParse(txtscore3.Text, out score3))
                        {

                            // Calculate the average of the three scores
                            average = (score1 + score2 + score3) / 3;

                            // Display the average 
                            lblaverageresult.Text = average.ToString("");
                        }
                        else
                        {
                            // Shows an error message if Test Scores is invalid
                            MessageBox.Show("Please enter a valid Test Score 1");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Test Score 2");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Test Score 3");
                }
            }
            catch (Exception ex)
            {
                // Display an error message 
                MessageBox.Show(" Error " + ex.Message);
            }
        }
        private void txtscore1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtscore2_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtscore3_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            // Clears Test Score 
            txtscore1.Clear();
            txtscore2.Clear();
            txtscore3.Clear();

            // Clear the average result
            lblaverageresult.Text = "";
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }
    }
}