﻿/*
 * Author: Connor Neil
 * Class name: SailorSodaMenu.xaml.cs
 * Purpose: Class used to represent the menu for customizing Sailor Soda
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
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
    /// Interaction logic for SailorSodaMenu.xaml
    /// </summary>
    public partial class SailorSodaMenu : UserControl
    {
        /// <summary>
        /// Holds reference to element of which the current menu is the child
        /// </summary>
        public MenuComponent Ancestor { get; set; }

        /// <summary>
        /// Creates SailorSodaMenu element
        /// </summary>
        public SailorSodaMenu(MenuComponent ancestor)
        {
            InitializeComponent();
            Ancestor = ancestor;
            this.DataContext = new SailorSoda();
            if (Ancestor.DataContext is Order order)
            {
                order.Add((IOrderItem)DataContext);
            }
        }

        /// <summary>
        /// Creates SailorSodaMenu element with already existing Markarth Milk
        /// </summary>
        public SailorSodaMenu(MenuComponent ancestor, SailorSoda item)
        {
            InitializeComponent();
            Ancestor = ancestor;
            this.DataContext = item;
        }
        /// <summary>
        /// Switches menu displayed on MenuComponent back to ItemSelectionComponent using ancestor's SwitchMenu Method
        /// </summary>
        void CompleteClick(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchMenu("ItemMenu");
        }
    }
}
