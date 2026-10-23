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

namespace Registration_Fee_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        { 
            String studentName = txtStudentName.Text;
            int studentId = int.Parse(txtStudentId.Text);
            int numberOfCourses = int.Parse(txtNumberOfCourses.Text);
            int studyLevel = int.Parse(txtStudylevel.Text);
            double transportFee = double.Parse(txtTranportFee.Text);

            if(int.TryParse(txtNumberOfCourses.Text, out numberOfCourses))
            {
                if(numberOfCourses >0 && numberOfCourses <= 8)
                {
                    //Fee
                    int fee_Per_Course= 0;

                    if (studyLevel == 1) 
                    {
                        fee_Per_Course = 40;
                        MessageBox.Show("Year 1 : $ " + fee_Per_Course);
                    }
                    else if (studyLevel == 2)
                    {
                        fee_Per_Course = 45;
                        MessageBox.Show("Year 2 : $ " + fee_Per_Course);
                    }
                    else if (studyLevel == 3)
                    {
                        fee_Per_Course = 50;
                        MessageBox.Show("Year 3 : $ " + fee_Per_Course);
                    }else if (studyLevel == 4)
                    {
                        fee_Per_Course = 55;
                        MessageBox.Show("Year 4 : $ " + fee_Per_Course);
                    }
                    else
                    {
                        MessageBox.Show("Enter Study Level");
                    }
                    if(double.TryParse(txtTranportFee.Text, out transportFee))
                    {
                        if (transportFee == 50) 
                        {
                            //Discount
                            double discount = 0;
                            if (numberOfCourses >= 6)
                            {
                                
                            }
                            else
                            {
                                discount = numberOfCourses * 0.1;
                                MessageBox.Show("Discount : $ " + discount);
                                MessageBox.Show("No Discount");
                            }
                            // Final Amount
                            double finalAmount = (transportFee + (numberOfCourses * fee_Per_Course)) - discount;
                            //Display
                            lblname.Text = "Name : " + studentName;
                            lblId.Text = "ID : " + studentId.ToString();
                            lblNumberCourses.Text = "Number of Courses : " + numberOfCourses.ToString();
                            lblStudyYear.Text = "Study Year : " + studyLevel.ToString();
                            lblTransportFee.Text = "Transport Fee : " + transportFee.ToString();
                            lblDiscount.Text = "Discount : " + discount;
                            lblTutionFee.Text = "Tuition Fee : " + (numberOfCourses * fee_Per_Course).ToString();
                            lblFinalAmount.Text = "Final Amount : " + finalAmount.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Add if transport fee is 50" + transportFee);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter a valid transport fee");
                    }

                }
                else
                {
                    MessageBox.Show(" Number of courses must be between 1 and 8");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid number of courses");
            }
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtStudentId.Clear();
            txtNumberOfCourses.Clear();
            txtStudylevel.Clear();
            txtTranportFee.Clear();

            lblname.Text = "";
            lblId.Text = "";
            lblNumberCourses.Text = "";
            lblStudyYear.Text = "";
            lblTransportFee.Text = "";
            lblDiscount.Text = "";
            lblTutionFee.Text = "";
            lblFinalAmount.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
