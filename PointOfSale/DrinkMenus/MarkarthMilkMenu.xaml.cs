/*
 * Author: Connor Neil
 * Class name: MarkarthMilk.xaml.cs
 * Purpose: Class used to represent the menu for customizing Markarth Milk
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
    /// Interaction logic for MarkarthMilkMenu.xaml
    /// </summary>
    public partial class MarkarthMilkMenu : UserControl
    {
        /// <summary>
        /// Holds reference to element of which the current menu is the child
        /// </summary>
        public MenuComponent Ancestor { get; set; }

        /// <summary>
        /// Creates MarkarthMilkMenu element
        /// </summary>
        public MarkarthMilkMenu(MenuComponent ancestor)
        {
            InitializeComponent();
            Ancestor = ancestor;
            this.DataContext = new MarkarthMilk();
            if (Ancestor.DataContext is Order order)
            {
                order.Add((IOrderItem)DataContext);
            }
        }

        /// <summary>
        /// Creates MarkarthMilkMenu using an already existing Markarth Milk (for modification)
        /// </summary>
        public MarkarthMilkMenu(MenuComponent ancestor, MarkarthMilk item)
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
