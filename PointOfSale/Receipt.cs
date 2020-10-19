/*
 * Author: Connor Neil
 * Class name: Receipt.cs
 * Purpose: Class used to represent a receipt and methods to output(print) the receipt
 */
using BleakwindBuffet.Data;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale
{
    /// <summary>
    /// Object representing a Receipt and the necessary information to print on it
    /// </summary>
    public class Receipt
    {
        /// <summary>
        /// creates the Receipt object
        /// </summary>
        /// <param name="order">Order that receipt is referencing</param>
        /// <param name="paymentMethod">Method that the order is being paid</param>
        /// <param name="change">Amount of change given if cash payment</param>
        public Receipt(Order order, string paymentMethod, double change)
        {
            Order = order;
            PaymentMethod = paymentMethod;
            Change = change;
        }

        /// <summary>
        /// Property holding order that the receipt covers
        /// </summary>
        public Order Order
        {
            get;
            private set;
        }

        /// <summary>
        /// Property for payment used
        /// </summary>
        public string PaymentMethod
        {
            get;
            private set;
        }
        
        /// <summary>
        /// Holds amount of change given
        /// </summary>
        public double Change
        {
            get;
            private set;
        }

        /// <summary>
        /// Prints the Receipt in a format that 
        /// </summary>
        public void PrintReceipt()
        {
            RecieptPrinter.PrintLine("Order #" + Order.Number.ToString());
            RecieptPrinter.PrintLine(DateTime.Now.ToString());
            RecieptPrinter.PrintLine("");
            RecieptPrinter.PrintLine("Items Ordered:");
            foreach (IOrderItem item in Order)
            {
                if(item is Combo combo)
                {
                    Entree entree = combo.Entree;
                    Side side = combo.Side;
                    Drink drink = combo.Drink;
                    RecieptPrinter.PrintLine(item.Name);
                    RecieptPrinter.PrintLine(string.Format("{0:C}", item.Price));
                    foreach (string s in item.SpecialInstructions)
                    {
                        if (s.Equals(entree.ToString())) RecieptPrinter.PrintLine("   " + entree.ToString());
                    else if (s.Equals(side.ToString())) RecieptPrinter.PrintLine("\n   " + side.ToString());
                    else if (s.Equals(drink.ToString())) RecieptPrinter.PrintLine("\n   " + drink.ToString());
                    else RecieptPrinter.PrintLine("      - " + s);
                    }
                    RecieptPrinter.PrintLine("");
                }
                else
                {
                    RecieptPrinter.PrintLine(item.Name);
                    RecieptPrinter.PrintLine(string.Format("{0:C}", item.Price));
                    foreach (string s in item.SpecialInstructions)
                    {
                        RecieptPrinter.PrintLine("  -" + s);
                    }
                    RecieptPrinter.PrintLine("");
                }
                
            }
            RecieptPrinter.PrintLine("");
            RecieptPrinter.PrintLine("Subtotal: " + string.Format("{0:C}", Order.Subtotal));
            RecieptPrinter.PrintLine("Tax: " + string.Format("{0:C}", Order.Tax));
            RecieptPrinter.PrintLine("Total: " + string.Format("{0:C}", Order.Total));
            RecieptPrinter.PrintLine("Payment Method: " + PaymentMethod);
            RecieptPrinter.PrintLine("Change: " + string.Format("{0:C}", Change));
            RecieptPrinter.CutTape();
        }
    }
}
