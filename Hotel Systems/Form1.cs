using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Room_Booking_Systems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Creating Variable 

            String Name;
            int Age;
            int NumberOfNights;
            int NumberOfGuests;

            String RoomType="";
            String Breakfast="";

            //1
            if (int.TryParse(txtguestAge.Text, out Age) 
                && int.TryParse(txtNumberOfNigth.Text, out NumberOfNights)
                && int.TryParse(txtNumberOfGuest.Text, out NumberOfGuests))
            {
                Name = txtguestName.Text;
                Age = int.Parse(txtguestAge.Text);
                NumberOfNights = int.Parse(txtNumberOfNigth.Text);
                NumberOfGuests = int.Parse(txtNumberOfGuest.Text);

                //Room Rate Calculation
                double RoomRate = 0;
                if (rdoStandard.Checked)
                {
                    RoomRate = 50;
                    RoomType = "Standard";
                }
                else if (rdoNormal.Checked)
                {
                    RoomRate = 80;
                    RoomType = "Normal";
                }
                else if (rdoHight.Checked)
                {
                    RoomRate = 130;
                    RoomType = "Hight";
                }
                else
                {
                    MessageBox.Show("Choose RoomType");
                }

                //Cost Rules 
                // calculate booking amount
                double booking_amount = NumberOfNights * RoomRate;

                //Discount Calculation
                double Discount = 0;
                if (NumberOfNights >= 1 && NumberOfNights <= 4)
                {
                    Discount = 0;
                }
                else if (NumberOfNights >= 5 && NumberOfNights <= 9)
                {
                    Discount = booking_amount* 0.05;
                }
                else if (NumberOfNights >= 10 )
                {
                    Discount = booking_amount * 0.12;
                }
                else
                {
                    MessageBox.Show("Fadlan Gali Number Of Nights");
                }


                double BreakfastCost = 0;
                if (checkBreakfast.Checked)
                {
                    Breakfast = "Yes";
                    BreakfastCost = NumberOfGuests * NumberOfNights* 10;
                }
                else
                {
                    Breakfast = "No";
                    BreakfastCost = 0;
                }

                    //service surcharge
                    double ServiceSurcharge = 0;
                if (NumberOfGuests >=4 )
                {
                    ServiceSurcharge= booking_amount * 0.05;
                }
                //Senior Discount
                double SeniorDiscount = 0;
                if ( Age >=60)
                {
                    SeniorDiscount = booking_amount * 0.05;
                }

                // Final Amount Calculation
                double FinalAmount = (booking_amount  + ServiceSurcharge + BreakfastCost) - Discount - SeniorDiscount; 

                //2
                if (Name != "")
                {
                    // 3
                    if (Age >= 18 && Age <= 90)
                    {
                        //4
                        if (NumberOfNights >= 1 && NumberOfNights <= 30)
                        {
                            //5
                            if (NumberOfGuests >= 1 && NumberOfGuests <= 6)
                            {
                                // determine  9
                                string booking_details = "";
                                //6 
                                if (rdoHight.Checked && NumberOfGuests > 6)
                                {
                                    booking_details = "Rejected";
                                    MessageBox.Show("Waxaad dooratay hight waxaa loo ogolyahay ugu badnaan 6");
                                    listBooking_details.Items.Add("Name :" + Name);
                                    listBooking_details.Items.Add("Age :" + Age);
                                    listBooking_details.Items.Add("Number Of Nights :" + NumberOfNights);
                                    listBooking_details.Items.Add("Number Of Guests :" + NumberOfGuests);
                                    listBooking_details.Items.Add("RoomType :" + RoomType);
                                    listBooking_details.Items.Add("Room Rate :" + RoomRate);
                                    listBooking_details.Items.Add("");
                                    listBooking_details.Items.Add("Booking status :" + booking_details);
                                }
                                //8
                                else if (rdoNormal.Checked && NumberOfGuests > 4)
                                {
                                    booking_details = "Rejected";
                                    MessageBox.Show("Waxaad dooratay Normal waxaa loo ogolyahay ugu badnaan 4");
                                    listBooking_details.Items.Add("Name :" + Name);
                                    listBooking_details.Items.Add("Age :" + Age);
                                    listBooking_details.Items.Add("Number Of Nights :" + NumberOfNights);
                                    listBooking_details.Items.Add("Number Of Guests :" + NumberOfGuests);
                                    listBooking_details.Items.Add("RoomType :" + RoomType);
                                    listBooking_details.Items.Add("Room Rate :" + RoomRate);
                                    listBooking_details.Items.Add("");
                                    listBooking_details.Items.Add("Booking status :" + booking_details);
                                    //7
                                }
                                else if (rdoStandard.Checked && NumberOfGuests > 2)
                                {
                                    booking_details = "Rejected";
                                    MessageBox.Show("Waxaad dooratay Standard waxaa loo ogolyahay ugu badnaan 2");
                                    listBooking_details.Items.Add("Name :" + Name);
                                    listBooking_details.Items.Add("Age :" + Age);
                                    listBooking_details.Items.Add("Number Of Nights :" + NumberOfNights);
                                    listBooking_details.Items.Add("Number Of Guests :" + NumberOfGuests);
                                    listBooking_details.Items.Add("RoomType :" + RoomType);
                                    listBooking_details.Items.Add("Room Rate :" + RoomRate);
                                    listBooking_details.Items.Add("");
                                    listBooking_details.Items.Add("Booking status :" + booking_details);
                                }
                                else
                                {
                                    booking_details = "Accepted";
                                    listBooking_details.Items.Add("Name :" +Name);
                                    listBooking_details.Items.Add("Age :" + Age );
                                    listBooking_details.Items.Add("Number Of Nights :" + NumberOfNights);
                                    listBooking_details.Items.Add("Number Of Guests :" + NumberOfGuests );
                                    listBooking_details.Items.Add("RoomType :" + RoomType);
                                    listBooking_details.Items.Add("Room Rate :" + RoomRate);
                                    listBooking_details.Items.Add("");


                                    listBooking_details.Items.Add("Breakfast:" + Breakfast);
                                    listBooking_details.Items.Add("Breakfast Cost :" + BreakfastCost);
                                    listBooking_details.Items.Add("Booking Amount :" + booking_amount);
                                    listBooking_details.Items.Add("Discount :" + Discount);
                                    listBooking_details.Items.Add("Senoir Discount :" + SeniorDiscount);
                                    listBooking_details.Items.Add("ServiceSurcharge :" + ServiceSurcharge);
                                    listBooking_details.Items.Add("Final Amount :" + FinalAmount);
                                    listBooking_details.Items.Add("");

                                    listBooking_details.Items.Add("Booking status :" + booking_details);
                                    



                                }

                            }
                            else
                            {
                                MessageBox.Show("Dadka imanaayan wa inay Udhaxeyaan 1 ilaa 6 ");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Inta Habeen aaad Joogaysid wa inay u dhaxesaa 1 ilaa 30");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Waxaa Inuu U dhaxeyaa Age Kaaga 18 Ilaa 90");
                    }

                }
                else
                {
                    MessageBox.Show("Lama Ogolo Magac La'aan");
                }
                

             
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtguestName.Clear();
            txtguestAge.Clear();
            txtNumberOfNigth.Clear();
            txtNumberOfGuest.Clear();

            listBooking_details.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
