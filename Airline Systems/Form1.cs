
using System;
using System.Security.Policy;
using System.Windows.Forms;

namespace Airline_Ticket_Booking_Systems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
          
            // Variables
            int PassengerAge;
            int NumberTicket;
            double Baggageweight;

            string bookingApproved = "";

            string Passengername = txtpassengername.Text;

            if (Passengername == "")
            {
                MessageBox.Show("Soo Geli Magaca Rakaabka");
            }
            else
            {
                if (int.TryParse(txtpassengerAge.Text, out PassengerAge) && double.TryParse(txtbaggageweight.Text, out Baggageweight))
                {
                    PassengerAge = int.Parse(txtpassengerAge.Text);
                    NumberTicket = int.Parse(txtNumberTicket.Text);
                    Baggageweight = double.Parse(txtbaggageweight.Text);

                    // Travel Class
                    double ticketPrice = 0;
                    string TicketClass = "";

                    if (rdofirstclass.Checked)
                    {
                        ticketPrice = 200;
                        TicketClass = "First Class";
                    }
                    else if (rdoNormalclass.Checked)
                    {
                        ticketPrice = 300;
                        TicketClass = "Normal Class";
                    }
                    else if (rdoBusinessClass.Checked)
                    {
                        ticketPrice = 400;
                        TicketClass = "Business Class";
                    }
                    else
                    {
                        MessageBox.Show("Choose Your Travel Class ");
                    }

                    // Basic Ticket Cost
                    double basicTicketCost = ticketPrice * NumberTicket;

                    // Ticket Discount
                    double ticketDiscount = 0;

                    if (NumberTicket >= 3 && NumberTicket <= 4)
                    {
                        ticketDiscount = basicTicketCost * 0.05;
                    }
                    else if (NumberTicket == 5)
                    {
                        ticketDiscount = basicTicketCost * 0.10;
                    }

                    // Age Discount
                    double ageDiscount = 0;

                    if (PassengerAge < 12)
                    {
                        ageDiscount = basicTicketCost * 0.20;
                    }
                    else if (PassengerAge >= 60)
                    {
                        ageDiscount = basicTicketCost * 0.10;
                    }

                    // Total Discount
                    double Discount = ticketDiscount + ageDiscount;

                    // Travel Insurance
                    double Insurance_Cost = 0;

                    if (checkadd.Checked)
                    {
                        Insurance_Cost = 25 * NumberTicket;
                    }


                    // Free Baggage Allowance
                    double freeBaggageLimit = 20 * NumberTicket;

                    double excessBaggage = 0;

                    if (Baggageweight > freeBaggageLimit)
                    {
                        excessBaggage = Baggageweight - freeBaggageLimit;
                    }


                    // Total Cost
                    double Total_Cost = basicTicketCost - Discount + Insurance_Cost;

                    // 2 
                    if (PassengerAge >= 1 && PassengerAge <= 100)
                    {
                        // 1 
                        if (int.TryParse(txtNumberTicket.Text, out NumberTicket))
                        {
                            // 3 
                            if (NumberTicket >= 1 && NumberTicket <= 5)
                            {
                                // 4 
                                if (Baggageweight >= 0 && Baggageweight <= 50)
                                {
                                    // 6 
                                    if (PassengerAge < 12 && rdofirstclass.Checked)
                                    {
                                        MessageBox.Show("Reason : waxaad dooratay first class age kaaguna wuxuu ka yaryahay 12");
                                        bookingApproved = "rejected";
                                        listBox1.Items.Add("Booking Details");
                                        listBox1.Items.Add(" ");
                                        listBox1.Items.Add("Passenger Name: " + Passengername);
                                        listBox1.Items.Add("Passenger Age: " + PassengerAge);
                                        listBox1.Items.Add("Number of Tickets: " + NumberTicket);
                                        listBox1.Items.Add("Ticket Class: " + TicketClass);
                                        listBox1.Items.Add("Baggage Weight: " + Baggageweight);
                                        listBox1.Items.Add(" ");

                                        listBox1.Items.Add("Booking status: " + bookingApproved);
                                    }
                                    else
                                    {
                                        bookingApproved = "Approved";

                                        listBox1.Items.Add("Booking Details");
                                        listBox1.Items.Add(" ");
                                        listBox1.Items.Add("Passenger Name: " + Passengername);
                                        listBox1.Items.Add("Passenger Age: " + PassengerAge);
                                        listBox1.Items.Add("Number of Tickets: " + NumberTicket);
                                        listBox1.Items.Add("Ticket Class: " + TicketClass);
                                        listBox1.Items.Add("Baggage Weight: " + Baggageweight);
                                        listBox1.Items.Add("Free Baggage Allowance: " + freeBaggageLimit + " kg");
                                        listBox1.Items.Add("Excess Baggage: " + excessBaggage);
                                        listBox1.Items.Add("Basic Ticket Cost: $" + basicTicketCost);
                                        listBox1.Items.Add("Ticket Discount: $" + ticketDiscount);
                                        listBox1.Items.Add("Age Discount: $" + ageDiscount);
                                        listBox1.Items.Add("Total Discount: $" + Discount);
                                        listBox1.Items.Add("Insurance Cost: $" + Insurance_Cost);
                                        listBox1.Items.Add(" ");
                                        listBox1.Items.Add("Total Cost: $" + Total_Cost);
                                        listBox1.Items.Add(" ");
                                        listBox1.Items.Add("Booking status: " + bookingApproved);

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Baggage weight ma noqon karo negative, " + "mana dhaafi karo 50 kg qofkiiba");

                                }
                            }

                            else
                            {
                                MessageBox.Show("Tickets ku waa inay u dhexeeyaan 1 ilaa 5");

                            }
                        }
                        else
                        {
                            MessageBox.Show("Soo Geli Number of Tickets sax ah");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Age waa inuu u dhexeeyaa 1 ilaa 100");

                    }
                }
                else
                {
                    MessageBox.Show("Soo geli Age sax ah");

                }
            }
        }
        

 
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpassengername.Clear();
            txtpassengerAge.Clear();
            txtNumberTicket.Clear();
            txtbaggageweight.Clear();

            listBox1.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
