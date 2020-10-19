using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for ComboMenu.xaml
    /// </summary>
    public partial class ComboMenu : UserControl
    {

        public MenuComponent Ancestor { get; set; }
        public ComboMenu(MenuComponent ancestor, IOrderItem item)
        {
            InitializeComponent();
            this.DataContext = item;
            Ancestor = ancestor;
        }

        void EntreeButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is Combo combo)
            {
                Ancestor.SwitchMenu(combo.Entree);
            }
        }

        void ReplaceEntree_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Combo combo)
            {
                string orderItem = entreeBox.Text.ToString();
                switch (orderItem)
                {

                    case "Briarheart Burger":
                        combo.Entree = new BriarheartBurger();
                        break;
                    case "Double Draugr":
                        combo.Entree = new DoubleDraugr();
                        break;
                    case "Garden Orc Omelette":
                        combo.Entree = new GardenOrcOmelette();
                        break;
                    case "Philly Poacher":
                        combo.Entree = new PhillyPoacher();
                        break;
                    case "Smokehouse Skeleton":
                        combo.Entree = new SmokehouseSkeleton();
                        break;
                    case "Thalmor Triple":
                        combo.Entree = new ThalmorTriple();
                        break;
                    case "Thug's T-Bone":
                        combo.Entree = new ThugsTBone();
                        break;
                }
                Ancestor.SwitchMenu(combo.Entree);
            }
        }

        void SideButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Combo combo)
            {
                Ancestor.SwitchMenu(combo.Side);
            }
        }

        void ReplaceSide_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Combo combo)
            {
                string orderItem = sideBox.Text.ToString();
                switch (orderItem)
                {

                    case "Dragonborn Waffle Fries":
                        combo.Side = new DragonbornWaffleFries();
                        break;
                    case "Fried Miraak":
                        combo.Side = new FriedMiraak();
                        break;
                    case "Mad Otar Grits":
                        combo.Side = new MadOtarGrits();
                        break;
                    case "Vokun Salad":
                        combo.Side = new VokunSalad();
                        break;
                }
                Ancestor.SwitchMenu(combo.Side);
            }
        }

        void DrinkButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Combo combo)
            {
                Ancestor.SwitchMenu(combo.Drink);
            }
        }

        void ReplaceDrink_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Combo combo)
            {
                string orderItem = drinkBox.Text.ToString();
                switch (orderItem)
                {

                    case "Aretino Apple Juice":
                        combo.Drink = new AretinoAppleJuice();
                        break;
                    case "Double Draugr":
                        combo.Drink = new CandlehearthCoffee();
                        break;
                    case "Garden Orc Omelette":
                        combo.Drink = new MarkarthMilk();
                        break;
                    case "Philly Poacher":
                        combo.Drink = new SailorSoda();
                        break;
                    case "Smokehouse Skeleton":
                        combo.Drink = new WarriorWater();
                        break;
                }
                Ancestor.SwitchMenu(combo.Drink);
            }

        }

        void FinishEditing_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.CurrentCombo = null;
            Ancestor.SwitchMenu("ItemMenu");
        }
    }
}
