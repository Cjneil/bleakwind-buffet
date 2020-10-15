/*
 * Author: Connor Neil
 * Class name: ItemSelectionComponent.xaml.cs
 * Purpose: Class used to represent the menu to select items
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
    /// Interaction logic for ItemSelectionComponent.xaml
    /// </summary>
    public partial class ItemSelectionComponent : UserControl
    {
        /// <summary>
        /// Holds reference to element of which the current menu is the child
        /// </summary>
        public MenuComponent Ancestor {get; set;}

        /// <summary>
        /// Creates ItemSelectionComponent element
        /// </summary>
        public ItemSelectionComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles clicks of buttons and calling the menu to be switched
        /// </summary>
        /// <param name="sender">Button pressed</param>
        /// <param name="e"></param>
        void ItemSelectionClick(object sender, RoutedEventArgs e)
        {
            Button buttonClicked = (Button) sender;
            string item = buttonClicked.Content.ToString();
            switch (item)
            {
                case "Aretino Apple Juice":
                    Ancestor.SwitchMenu("Aretino Apple Juice");
                    break;
                case "Candlehearth Coffee":
                    Ancestor.SwitchMenu("Candlehearth Coffee");
                    break;
                case "Markarth Milk":
                    Ancestor.SwitchMenu("Markarth Milk");
                    break;
                case "Sailor Soda":
                    Ancestor.SwitchMenu("Sailor Soda");
                    break;
                case "Warrior Water":
                    Ancestor.SwitchMenu("Warrior Water");
                    break;
                case "Briarheart Burger":
                    Ancestor.SwitchMenu("Briarheart Burger");
                    break;
                case "Double Draugr":
                    Ancestor.SwitchMenu("Double Draugr");
                    break;
                case "Garden Orc Omelette":
                    Ancestor.SwitchMenu("Garden Orc Omelette");
                    break;
                case "Philly Poacher":
                    Ancestor.SwitchMenu("Philly Poacher");
                    break;
                case "Smokehouse Skeleton":
                    Ancestor.SwitchMenu("Smokehouse Skeleton");
                    break;
                case "Thalmor Triple":
                    Ancestor.SwitchMenu("Thalmor Triple");
                    break;
                case "Dragonborn Waffle Fries":
                    Ancestor.SwitchMenu("Dragonborn Waffle Fries");
                    break;
                case "Fried Miraak":
                    Ancestor.SwitchMenu("Fried Miraak");
                    break;
                case "Mad Otar Grits":
                    Ancestor.SwitchMenu("Mad Otar Grits");
                    break;
                case "Vokun Salad":
                    Ancestor.SwitchMenu("Vokun Salad");
                    break;
                case "Thugs T-Bone":
                    if (Ancestor.DataContext is Order order) order.Add(new ThugsTBone());
                    break;
            }
        }
    }
}
