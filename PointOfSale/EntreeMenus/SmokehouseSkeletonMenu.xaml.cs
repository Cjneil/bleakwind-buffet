/*
 * Author: Connor Neil
 * Class name: SmokehouseSkeletonMenu.xaml.cs
 * Purpose: Class used to represent the menu for customizing Smokehouse Skeleton
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for SmokehouseSkeletonMenu.xaml
    /// </summary>
    public partial class SmokehouseSkeletonMenu : UserControl
    {
        /// <summary>
        /// Holds reference to element of which the current menu is the child
        /// </summary>
        public MenuComponent Ancestor { get; set; }

        /// <summary>
        /// Creates SmokehouseSkeletonMenu element
        /// </summary>
        public SmokehouseSkeletonMenu(MenuComponent ancestor)
        {
            InitializeComponent();
            Ancestor = ancestor;
            this.DataContext = new SmokehouseSkeleton();
            if (Ancestor.DataContext is Order order)
            {
                order.Add((IOrderItem)DataContext);
            }
        }

        /// <summary>
        /// Overload to create a menu to modify an existing item
        /// </summary>
        /// <param name="ancestor">Menu of which this is a child</param>
        /// <param name="item">Existing item to be modified</param>
        public SmokehouseSkeletonMenu(MenuComponent ancestor, SmokehouseSkeleton item)
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
