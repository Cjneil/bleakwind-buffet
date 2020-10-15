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


        private void CreateCombo_Click(object sender, RoutedEventArgs e)
        {
        }

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

        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            if(Ancestor.DataContext is Order order)
            {
                order.ClearOrder();
            }
        }
    }
}
