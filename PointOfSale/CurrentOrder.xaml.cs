/*
 * Author: Connor Neil
 * Class name: CurrentOrder.xaml.cs
 * Purpose: Class used to represent the sidebar listing all items currently on the order.
 */
using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for CurrentOrder.xaml
    /// </summary>
    public partial class CurrentOrder : UserControl
    {
        public MenuComponent Ancestor { get; set; }

        /// <summary>
        /// Creates CurrentOrder element 
        /// </summary>
        public CurrentOrder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a new combo using the selected items in the listview
        /// </summary>
        /// <param name="sender">Create Combo button</param>
        /// <param name="e">Event args</param>
        private void CreateCombo_Click(object sender, RoutedEventArgs e)
        {
            Drink comboDrink = null;
            Entree comboEntree= null;
            Side comboSide = null;
            if (DataContext is Order order && orderList.SelectedItems.Count == 3)
            {
                for (int i = 0; i < orderList.SelectedItems.Count; i++)
                {
                    if (orderList.SelectedItems[i] is Drink drink)
                    {
                        comboDrink = drink;
                    }
                    else if (orderList.SelectedItems[i] is Side side)
                    {
                        comboSide = side;
                    }
                    else if (orderList.SelectedItems[i] is Entree entree)
                    {
                        comboEntree = entree;
                    }
                }
                if(comboDrink != null && comboEntree != null && comboSide != null) {
                    while (orderList.SelectedItems.Count > 0)
                    {
                        order.Remove((IOrderItem)orderList.SelectedItem);
                    }
                    order.Add(new Combo(comboDrink, comboEntree, comboSide));
                }
            }
        }

        /// <summary>
        /// Modifies the currently selected item
        /// </summary>
        /// <param name="sender">Modify Item button</param>
        /// <param name="e">Event args</param>
        private void ModifyItem_Click(object sender, RoutedEventArgs e)
        {
            if(orderList.SelectedItem != null && orderList.SelectedItems.Count == 1)
            {
                Ancestor.SwitchMenu((IOrderItem)orderList.SelectedItem);
                orderList.SelectedItems.Clear();
            }else if(orderList.SelectedItems.Count != 1)
            {
                orderList.SelectedItems.Clear();
            }
        }

        /// <summary>
        /// Removes the currently selected item(s)
        /// </summary>
        /// <param name="sender">Remove item button</param>
        /// <param name="e">Event Args</param>
        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order && orderList.HasItems == true )
            {
                while (orderList.SelectedItems.Count > 0)
                {
                    order.Remove((IOrderItem) orderList.SelectedItem);
                }
            }
        }

        /// <summary>
        /// Calls the menu's method to complete the order
        /// </summary>
        /// <param name="sender">Complete order button</param>
        /// <param name="e">event args</param>
        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.Complete();
        }

        /// <summary>
        /// Cancels the order completely by calling Menu's reset method
        /// </summary>
        /// <param name="sender">Cancel button</param>
        /// <param name="e">event args</param>
        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.Reset();
        }
    }
}
