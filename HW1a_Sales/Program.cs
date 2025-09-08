// HW1a Sales Total

// Your Name: Tagen Burke
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        /*
         * (Order)
         * Question (string)
         * String ticket amount + Enter float(double)
         * String price of each ticker+ Enter float(double)
         * string Your subtotal + Calulate (ticket * price)
         * string tax + Calulate (subtotal * 0.085)
         * string total + Calulate (subtotal + tax)
         */

        static void Main(string[] args)
        {
        string question = "what is the sport name of the ticket you are purchasing? \t (Football or Soccer)";
            const string Football = "football";
            const string Soccer = "soccer";
            string TicketName;

        string ticketAmount = "How many tickets are you purchasing?";
            double tickets;

        string priceOfEachTicket = "Price of each ticket:";
            double price;

        string yourSubtotal = "\v\tYour subtotal for your bill is: ";
            double subtotal;

        string taxString = "\tYour salestax for your bill is: ";
            double tax;

        string totalString = "\tYour total for your bill is: ";
            double total;

            Console.WriteLine(question);
            TicketName = Console.ReadLine();
            switch (TicketName.ToLower())///Found this on page 71 of the textbook
            {
                case Football:
                    price = 49.99f;
                    break;
                case Soccer:
                    price = 39.99f;
                    break;
                default:
                    price = 49.99f;
                    break;
            }
     
            Console.WriteLine(ticketAmount);
            tickets = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(priceOfEachTicket + price.ToString("N2"));

            subtotal = tickets * price;
            Console.WriteLine(yourSubtotal + subtotal.ToString("C"));

            tax = subtotal * 0.085;
            Console.WriteLine(taxString + tax.ToString("C"));

            total = subtotal + tax;
            Console.WriteLine(totalString + total.ToString("C"));
            Console.ReadLine();

        }
    }
}
