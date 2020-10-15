/*
 * Author: Connor Neil
 * Class name: MenuComponent.xaml.cs
 * Purpose: Class that represents the container to switch between menus
 */
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
    /// Interaction logic for MenuComponent.xaml
    /// </summary>
    public partial class MenuComponent : UserControl
    {
        /// <summary>
        /// Creates MenuComponent element
        /// </summary>
        public MenuComponent()
        {
            InitializeComponent();
            menu.Ancestor = this;
            orderList.Ancestor = this;
            this.DataContext = new Order();
        }

        /// <summary>
        /// Handles switching menus based on which click event calls it
        /// </summary>
        /// <param name="name">Name of menu to switch to</param>
        public void SwitchMenu(string name)
        {
            switch (name)
            {
                case "Aretino Apple Juice":
                    menuInterface.Child = new AretinoJuiceMenu(this);
                    break;
                case "Candlehearth Coffee":
                    menuInterface.Child = new CandlehearthMenu(this);
                    break;
                case "Markarth Milk":
                    menuInterface.Child = new MarkarthMilkMenu(this);
                    break;
                case "Sailor Soda":
                    menuInterface.Child = new SailorSodaMenu(this);
                    break;
                case "Warrior Water":
                    menuInterface.Child = new WarriorWaterMenu(this);
                    break;
                case "Briarheart Burger":
                    menuInterface.Child = new BriarheartMenu(this);
                    break;
                case "Double Draugr":
                    menuInterface.Child = new DoubleDraugrMenu(this);
                    break;
                case "Garden Orc Omelette":
                    menuInterface.Child = new GardenOrcMenu(this);
                    break;
                case "Philly Poacher":
                    menuInterface.Child = new PhillyPoacherMenu(this);
                    break;
                case "Smokehouse Skeleton":
                    menuInterface.Child = new SmokehouseSkeletonMenu(this);
                    break;
                case "Thalmor Triple":
                    menuInterface.Child = new ThalmorTripleMenu(this);
                    break;
                case "Dragonborn Waffle Fries":
                    menuInterface.Child = new DragonbornFriesMenu(this);
                    break;
                case "Fried Miraak":
                    menuInterface.Child = new FriedMiraakMenu(this);
                    break;
                case "Mad Otar Grits":
                    menuInterface.Child = new MadOtarGritsMenu(this);
                    break;
                case "Vokun Salad":
                    menuInterface.Child = new VokunSaladMenu(this);
                    break;
                case "ItemMenu":
                    var newMenu = new ItemSelectionComponent();
                    newMenu.Ancestor = this;
                    menuInterface.Child = newMenu;
                    break;
            }
        }

        /// <summary>
        /// Handles switching menus for modification of an existing item
        /// </summary>
        /// <param name="name">Name of menu to switch to</param>
        public void SwitchMenu(IOrderItem orderItem)
        {
            if(orderItem is AretinoAppleJuice)
            {
                menuInterface.Child = new AretinoJuiceMenu(this, orderItem);
            }
            else if(orderItem is CandlehearthCoffee coffee)
            {
                menuInterface.Child = new CandlehearthMenu(this, coffee);
            }
            else if (orderItem is MarkarthMilk milk) 
            {
                menuInterface.Child = new MarkarthMilkMenu(this, milk);
            }
            else if (orderItem is SailorSoda soda)
            {
                menuInterface.Child = new SailorSodaMenu(this, soda);
            }
            else if (orderItem is WarriorWater water)
            {
                menuInterface.Child = new WarriorWaterMenu(this, water);
            }
            else if (orderItem is BriarheartBurger briar)
            {
                menuInterface.Child = new BriarheartMenu(this, briar);
            }
            else if (orderItem is DoubleDraugr draugr)
            {
                menuInterface.Child = new DoubleDraugrMenu(this, draugr);
            }
            else if (orderItem is GardenOrcOmelette orc)
            {
                menuInterface.Child = new GardenOrcMenu(this, orc);
            }
            else if (orderItem is PhillyPoacher philly)
            {
                menuInterface.Child = new PhillyPoacherMenu(this, philly);
            }
            else if (orderItem is SmokehouseSkeleton smoke)
            {
                menuInterface.Child = new SmokehouseSkeletonMenu(this, smoke);
            }
            else if (orderItem is ThalmorTriple triple)
            {
                menuInterface.Child = new ThalmorTripleMenu(this, triple);
            }
            else if (orderItem is DragonbornWaffleFries dragon)
            {
                menuInterface.Child = new DragonbornFriesMenu(this, dragon);
            }
            else if (orderItem is FriedMiraak fried)
            {
                menuInterface.Child = new FriedMiraakMenu(this, fried);
            }
            else if (orderItem is MadOtarGrits otar)
            {
                menuInterface.Child = new MadOtarGritsMenu(this, otar);
            }
            else if (orderItem is VokunSalad vokun)
            {
                menuInterface.Child = new VokunSaladMenu(this, vokun);
            }
        }

        public void Reset()
        {
            this.DataContext = new Order();
        }


    }
}
