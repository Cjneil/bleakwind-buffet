/*
 * Author: Connor Neil
 * Class name: MadOtarGritsMenu.xaml.cs
 * Purpose: Class used to represent the menu for customizing Mad Otar Grits
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
    /// Interaction logic for MadOtarGritsMenu.xaml
    /// </summary>
    public partial class MadOtarGritsMenu : UserControl
    {
        /// <summary>
        /// Holds reference to element of which the current menu is the child
        /// </summary>
        public MenuComponent Ancestor { get; set; }

        /// <summary>
        /// Creates MadOtarGritsMenu element
        /// </summary>
        public MadOtarGritsMenu(MenuComponent ancestor)
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
