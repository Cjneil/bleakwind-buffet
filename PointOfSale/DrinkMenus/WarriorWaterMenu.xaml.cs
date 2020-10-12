/*
 * Author: Connor Neil
 * Class name: WarriorWaterMenu.xaml.cs
 * Purpose: Class used to represent the menu for customizing Warrior Water
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
    /// Interaction logic for WarriorWaterMenu.xaml
    /// </summary>
    public partial class WarriorWaterMenu : UserControl
    {
        /// <summary>
        /// Holds reference to element of which the current menu is the child
        /// </summary>
        public MenuComponent Ancestor { get; set; }

        /// <summary>
        /// Creates WarriorWaterMenu element
        /// </summary>
        public WarriorWaterMenu(MenuComponent ancestor)
        {
            InitializeComponent();
            Ancestor = ancestor;
            this.DataContext = new WarriorWater();
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
