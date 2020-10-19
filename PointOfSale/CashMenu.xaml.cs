/*
 * Author: Connor Neil
 * Class name: CashMenu.xaml.cs
 * Purpose: Class used to represent a cash transaction
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
    /// Interaction logic for CashMenu.xaml
    /// </summary>
    public partial class CashMenu : UserControl
    {
        /// <summary>
        /// Holds reference to element of which the current menu is the child
        /// </summary>
        public MenuComponent Ancestor { get; set; }
        /// <summary>
        /// Viewmodel
        /// </summary>
        CashRegister drawer;
        /// <summary>
        /// creates a cash menu
        /// </summary>
        /// <param name="ancestor"></param>
        public CashMenu(MenuComponent ancestor)
        {
            InitializeComponent();
            Ancestor = ancestor;
            drawer = new CashRegister((Order)Ancestor.DataContext);
            this.DataContext = drawer;
        }
        /// <summary>
        /// Returns to order customization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Return_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchMenu("ItemMenu");
        }
    }
}
