﻿/*
 * Author: Connor Neil
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Linq;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void MenuEntreesMethodShouldResultInSevenItems()
        {
            var entrees = Menu.Entrees();
            Assert.Equal(7, entrees.Count());
        }

        [Fact]
        public void MenuSidesMethodShouldResultInTwelveItems()
        {
            var sides = Menu.Sides();
            Assert.Equal(12, sides.Count());
        }

        [Fact]
        public void MenuDrinksMethodShouldResultInThirtyItems()
        {
            var drinks = Menu.Drinks();
            Assert.Equal(30, drinks.Count());
        }

        [Fact]
        public void MenuFullMenuMethodShouldResultInFortyNineItems()
        {
            var menu = Menu.FullMenu();
            Assert.Equal(49, menu.Count());
        }

        [Fact]
        public void MenuContainsAllEntrees()
        {
            var entrees = Menu.Entrees();
            Assert.Collection(entrees,
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Double Draugr", item.ToString()),
                item => Assert.Equal("Garden Orc Omelette", item.ToString()),
                item => Assert.Equal("Philly Poacher", item.ToString()),
                item => Assert.Equal("Smokehouse Skeleton", item.ToString()),
                item => Assert.Equal("Thalmor Triple", item.ToString()),
                item => Assert.Equal("Thugs T-Bone", item.ToString())
                );
        }

        [Fact]
        public void MenuContainsAllSides()
        {
            var sides = Menu.Sides();
            Assert.Collection(sides,
                    item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString()),
                    item => Assert.Equal("Medium Dragonborn Waffle Fries", item.ToString()),
                    item => Assert.Equal("Large Dragonborn Waffle Fries", item.ToString()),
                    item => Assert.Equal("Small Fried Miraak", item.ToString()),
                    item => Assert.Equal("Medium Fried Miraak", item.ToString()),
                    item => Assert.Equal("Large Fried Miraak", item.ToString()),
                    item => Assert.Equal("Small Mad Otar Grits", item.ToString()),
                    item => Assert.Equal("Medium Mad Otar Grits", item.ToString()),
                    item => Assert.Equal("Large Mad Otar Grits", item.ToString()),
                    item => Assert.Equal("Small Vokun Salad", item.ToString()),
                    item => Assert.Equal("Medium Vokun Salad", item.ToString()),
                    item => Assert.Equal("Large Vokun Salad", item.ToString())
            );
        }

        [Fact]
        public void MenuContainsAllDrinks()
        {
            var drinks = Menu.Drinks();
            Assert.Collection(drinks,
                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Large Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Small Markarth Milk", item.ToString()),
                item => Assert.Equal("Medium Markarth Milk", item.ToString()),
                item => Assert.Equal("Large Markarth Milk", item.ToString()),
                item => Assert.Equal("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Warrior Water", item.ToString()),
                item => Assert.Equal("Medium Warrior Water", item.ToString()),
                item => Assert.Equal("Large Warrior Water", item.ToString())
            );
        }

        [Fact]
        public void MenuContainsAllOrderItems()
        {
            var menu = Menu.FullMenu();
            Assert.Collection(menu,
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Double Draugr", item.ToString()),
                item => Assert.Equal("Garden Orc Omelette", item.ToString()),
                item => Assert.Equal("Philly Poacher", item.ToString()),
                item => Assert.Equal("Smokehouse Skeleton", item.ToString()),
                item => Assert.Equal("Thalmor Triple", item.ToString()),
                item => Assert.Equal("Thugs T-Bone", item.ToString()),
                item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Large Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Small Fried Miraak", item.ToString()),
                item => Assert.Equal("Medium Fried Miraak", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString()),
                item => Assert.Equal("Small Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Large Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Small Vokun Salad", item.ToString()),
                item => Assert.Equal("Medium Vokun Salad", item.ToString()),
                item => Assert.Equal("Large Vokun Salad", item.ToString()),
                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Large Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Small Markarth Milk", item.ToString()),
                item => Assert.Equal("Medium Markarth Milk", item.ToString()),
                item => Assert.Equal("Large Markarth Milk", item.ToString()),
                item => Assert.Equal("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Warrior Water", item.ToString()),
                item => Assert.Equal("Medium Warrior Water", item.ToString()),
                item => Assert.Equal("Large Warrior Water", item.ToString())
                );
        }

        [Fact]
        public void MenuSearchReturnsCorrectItems()
        {

            var menu = Menu.Search("Fried Miraak");
            Assert.Collection(menu,
                item => Assert.Equal("Small Fried Miraak", item.ToString()),
                item => Assert.Equal("Medium Fried Miraak", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString()));
            menu = Menu.Search(null);
            Assert.Collection(menu,
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Double Draugr", item.ToString()),
                item => Assert.Equal("Garden Orc Omelette", item.ToString()),
                item => Assert.Equal("Philly Poacher", item.ToString()),
                item => Assert.Equal("Smokehouse Skeleton", item.ToString()),
                item => Assert.Equal("Thalmor Triple", item.ToString()),
                item => Assert.Equal("Thugs T-Bone", item.ToString()),
                item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Medium Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Large Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Small Fried Miraak", item.ToString()),
                item => Assert.Equal("Medium Fried Miraak", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString()),
                item => Assert.Equal("Small Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Medium Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Large Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Small Vokun Salad", item.ToString()),
                item => Assert.Equal("Medium Vokun Salad", item.ToString()),
                item => Assert.Equal("Large Vokun Salad", item.ToString()),
                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Large Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Medium Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Large Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Small Markarth Milk", item.ToString()),
                item => Assert.Equal("Medium Markarth Milk", item.ToString()),
                item => Assert.Equal("Large Markarth Milk", item.ToString()),
                item => Assert.Equal("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Medium Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Large Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Warrior Water", item.ToString()),
                item => Assert.Equal("Medium Warrior Water", item.ToString()),
                item => Assert.Equal("Large Warrior Water", item.ToString())
                );
            menu = Menu.Search("small");
            Assert.Collection(menu,
                item => Assert.Equal("Small Dragonborn Waffle Fries", item.ToString()),
                item => Assert.Equal("Small Fried Miraak", item.ToString()),
                item => Assert.Equal("Small Mad Otar Grits", item.ToString()),
                item => Assert.Equal("Small Vokun Salad", item.ToString()),
                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Small Candlehearth Coffee", item.ToString()),
                item => Assert.Equal("Small Markarth Milk", item.ToString()),
                item => Assert.Equal("Small Blackberry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Cherry Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Grapefruit Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Lemon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Peach Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Watermelon Sailor Soda", item.ToString()),
                item => Assert.Equal("Small Warrior Water", item.ToString())
                );
            menu = Menu.Search("Some random input");
            Assert.Empty(menu);
        }

        [Fact]
        public void FilterByCaloriesFiltersCorrectly()
        {
            var fullMenu = new List<IOrderItem>();
            fullMenu.Add(new AretinoAppleJuice() { Size = Size.Medium });
            fullMenu.Add(new BriarheartBurger());
            fullMenu.Add(new FriedMiraak() { Size = Size.Large });
            var menu = Menu.FilterByCalories(fullMenu, null, null);
            Assert.Collection(menu,
                item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString())
                );
            menu = Menu.FilterByCalories(fullMenu, null, 742);
            Assert.Collection(menu,
                item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString())
                );
            menu = Menu.FilterByCalories(fullMenu, 307, null);
            Assert.Collection(menu,
                item => Assert.Equal("Briarheart Burger", item.ToString())
                );
            menu = Menu.FilterByCalories(fullMenu, 89, 742);
            Assert.Collection(menu,
                item => Assert.Equal("Large Fried Miraak", item.ToString())
                );
        }

        [Fact]
        public void FilterByPriceFiltersCorrectly()
        {
            var fullMenu = new List<IOrderItem>();
            fullMenu.Add(new AretinoAppleJuice() { Size = Size.Medium });
            fullMenu.Add(new BriarheartBurger());
            fullMenu.Add(new FriedMiraak() { Size = Size.Large });
            var menu = Menu.FilterByPrice(fullMenu, null, null);
            Assert.Collection(menu,
                item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString())
                );
            menu = Menu.FilterByPrice(fullMenu, null, 6.31);
            Assert.Collection(menu,
                item => Assert.Equal("Medium Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString())
                );
            menu = Menu.FilterByPrice(fullMenu, 0.88, null);
            Assert.Collection(menu,
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Large Fried Miraak", item.ToString())
                );
            menu = Menu.FilterByPrice(fullMenu, 0.88, 6.31);
            Assert.Collection(menu,
                item => Assert.Equal("Large Fried Miraak", item.ToString())
                );
        }

        [Fact]
        public void FilterByItemTypesFiltersCorrectly()
        {
            var fullMenu = new List<IOrderItem>();
            fullMenu.Add(new AretinoAppleJuice());
            fullMenu.Add(new BriarheartBurger());
            fullMenu.Add(new FriedMiraak());
            string[] options = { "Entrees", "Sides", "Drinks" };
            var menu = Menu.FilterByItemTypes(fullMenu, options);
            Assert.Collection(menu,
                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Briarheart Burger", item.ToString()),
                item => Assert.Equal("Small Fried Miraak", item.ToString())
                );
            options[0] = null;
            menu = Menu.FilterByItemTypes(fullMenu, options);
            Assert.Collection(menu,
                item => Assert.Equal("Small Aretino Apple Juice", item.ToString()),
                item => Assert.Equal("Small Fried Miraak", item.ToString())
                );
            options[2] = null;
            menu = Menu.FilterByItemTypes(fullMenu, options);
            Assert.Collection(menu,
                item => Assert.Equal("Small Fried Miraak", item.ToString())
                );
        }
    }
}
