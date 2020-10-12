/*
 * Author: Connor Neil
 * Class name: CandlehearthMenu.xaml.cs
 * Purpose: Class used to represent the menu for customizing Candlehearth Coffee
 */
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
    /// Interaction logic for CandlehearthMenu.xaml
    /// </summary>
    public partial class CandlehearthMenu : UserControl
    {
        /// <summary>
        /// Holds reference to element of which the current menu is the child
        /// </summary>
        public MenuComponent Ancestor { get; set; }

        /// <summary>
        /// Creates CandlehearthMenu element
        /// </summary>
        public CandlehearthMenu(MenuComponent ancestor)
        {
            InitializeComponent();
            Ancestor = ancestor;
            this.DataContext = new CandlehearthCoffee();
        }

        /// <summary>
        /// Switches menu displayed on MenuComponent back to ItemSelectionComponent using ancestor's SwitchMenu Method
        /// </summary>
        void CompleteClick(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchMenu("ItemMenu");
        }

        /// <summary>
        /// Switches menu displayed on MenuComponent back to ItemSelectionComponent using ancestor's SwitchMenu Method
        /// </summary>
        private void CancelClick(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchMenu("ItemMenu");
        }
    }
}
