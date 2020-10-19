/*
 * Author: Connor Neil
 * Class name: PaymentOptionsMenu.xaml.cs
 * Purpose: Xaml class for menu with options on how to pay for an order
 */
using BleakwindBuffet.Data;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptionsMenu.xaml
    /// </summary>
    public partial class PaymentOptionsMenu : UserControl
    {
        /// <summary>
        /// Holds reference to element of which the current menu is the child
        /// </summary>
        public MenuComponent Ancestor { get; set; }

        /// <summary>
        /// basic constructor
        /// </summary>
        public PaymentOptionsMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click handler for Credit/Debit button 
        /// </summary>
        /// <param name="sender">Credit/Debit button</param>
        /// <param name="e"></param>
        void CreditDebit_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CardTransactionResult result = CardReader.RunCard(order.Total);
                cardApprovalText.Text = result.ToString();
                if(result == CardTransactionResult.Approved)
                {
                    Receipt r = new Receipt(order, "Card", 0);
                    r.PrintReceipt();
                    Ancestor.Reset();
                }
            }
        }

        /// <summary>
        /// Calls Menu's method to switch to Cash payment screen
        /// </summary>
        /// <param name="sender"> Cash button </param>
        /// <param name="e">Event Args</param>
        void Cash_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.CashPayment();
        }

        /// <summary>
        /// Returns to order customization
        /// </summary>
        /// <param name="sender">Return to Order button</param>
        /// <param name="e">Event Args</param>
        void ReturnToOrder_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchMenu("ItemMenu");
        }
    }
}
