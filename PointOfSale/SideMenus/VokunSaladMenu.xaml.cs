/*
 * Author: Connor Neil
 * Class name: VokunSaladMenu.xaml.cs
 * Purpose: Class used to represent the menu for customizing Vokun Salad
 */
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
    /// Interaction logic for VokunSaladMenu.xaml
    /// </summary>
    public partial class VokunSaladMenu : UserControl
    {
        /// <summary>
        /// Holds reference to element of which the current menu is the child
        /// </summary>
        public MenuComponent Ancestor { get; set; }

        /// <summary>
        /// Creates VokunSaladMenu element
        /// </summary>
        public VokunSaladMenu(MenuComponent ancestor)
        {
            InitializeComponent();
            Ancestor = ancestor;
        }

        /// <summary>
        /// Switches menu displayed on MenuComponent back to ItemSelectionComponent using ancestor's SwitchMenu Method
        /// </summary>
        private void CompleteClick(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchMenu("ItemMenu");
        }
    }
}
