/*
 * Author: Connor Neil
 * Class name: FriedMiraakMenu.xaml.cs
 * Purpose: Class used to represent the menu for customizing Fried Miraak
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
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
    /// Interaction logic for FriedMiraakMenu.xaml
    /// </summary>
    public partial class FriedMiraakMenu : UserControl
    {
        /// <summary>
        /// Holds reference to element of which the current menu is the child
        /// </summary>
        public MenuComponent Ancestor { get; set; }
        /// <summary>
        /// Creates FriedMiraakMenu element
        /// </summary>
        public FriedMiraakMenu(MenuComponent ancestor)
        {
            InitializeComponent();
            Ancestor = ancestor;
            this.DataContext = new FriedMiraak();
            if (Ancestor.DataContext is Order order)
            {
                order.Add((IOrderItem)DataContext);
            }
        }

        /// <summary>
        /// Override to create a menu to modify an existing item
        /// </summary>
        /// <param name="ancestor">Menu of which this is a child</param>
        /// <param name="item">Existing item to be modified</param>
        public FriedMiraakMenu(MenuComponent ancestor, FriedMiraak item)
        {
            InitializeComponent();
            Ancestor = ancestor;
            this.DataContext = item;
        }

        /// <summary>
        /// Switches menu displayed on MenuComponent back to ItemSelectionComponent using ancestor's SwitchMenu Method
        /// and adds item to the overall order
        /// </summary>
        void CompleteClick(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchMenu("ItemMenu");
        }
    }
}
