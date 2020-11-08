/*
 * Author: Connor Neil
 * Class Name: Menu.cs
 * Purpose: Provide methods to access enumerable objects representing all objects of various types on the menu including entrees,
 * sides, drinks, and the full menu.
 * 
 */
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Static class representing the menu and all items available on it (including all variants)
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Provides an enumerable form of all entrees offered by the buffet
        /// </summary>
        /// <returns>An IEnumerable item consisting of IOrderItems representing all possible entrees </returns>
        public static IEnumerable<IOrderItem> Entrees(){
            List<IOrderItem> entreeList = new List<IOrderItem>();
            entreeList.Add(new BriarheartBurger());
            entreeList.Add(new DoubleDraugr());
            entreeList.Add(new GardenOrcOmelette());
            entreeList.Add(new PhillyPoacher());
            entreeList.Add(new SmokehouseSkeleton());
            entreeList.Add(new ThalmorTriple());
            entreeList.Add(new ThugsTBone());
            return entreeList;
        }

        /// <summary>
        /// Provides an enumerable form of all Sides offered by the buffet
        /// </summary>
        /// <returns>An IEnumerable item consisting of IOrderItems representing all possible sides </returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sidesList = new List<IOrderItem>();
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries d = new DragonbornWaffleFries();
                d.Size = size;
                sidesList.Add(d);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                FriedMiraak f = new FriedMiraak();
                f.Size = size;
                sidesList.Add(f);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                MadOtarGrits m = new MadOtarGrits();
                m.Size = size;
                sidesList.Add(m);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                VokunSalad v = new VokunSalad();
                v.Size = size;
                sidesList.Add(v);
            }
            return sidesList;
        }

        /// <summary>
        /// Provides an enumerable form of all Drinks offered by the buffet
        /// </summary>
        /// <returns>An IEnumerable item consisting of IOrderItems representing all possible drinks </returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinkList = new List<IOrderItem>();
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice a = new AretinoAppleJuice();
                a.Size = size;
                drinkList.Add(a);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                CandlehearthCoffee c = new CandlehearthCoffee();
                c.Size = size;
                drinkList.Add(c);
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                MarkarthMilk m = new MarkarthMilk();
                m.Size = size;
                drinkList.Add(m);
            }
            
            foreach (SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
            {
                foreach (Size size in Enum.GetValues(typeof(Size)))
                {
                    SailorSoda s = new SailorSoda();
                    s.Size = size;
                    s.Flavor = flavor;
                    drinkList.Add(s);
                }
            }
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                WarriorWater w = new WarriorWater();
                w.Size = size;
                drinkList.Add(w);
            }
            return drinkList;
        }

        /// <summary>
        /// Provides an enumerable form of all items offered by the buffet
        /// </summary>
        /// <returns>An IEnumerable item consisting of IOrderItems representing all possible orderable items </returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();
            fullMenu.AddRange(Entrees());
            fullMenu.AddRange(Sides());
            fullMenu.AddRange(Drinks());
            return fullMenu;
        }

        /// <summary>
        /// Searches the menu for matching items
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of order items</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return FullMenu();
            foreach (IOrderItem orderItem in FullMenu())
            {
                //For some reason string.Contains(string, StringComparison) was not an overload so I put the basic string contains for now
                if (orderItem.Name.ToLower().Contains(terms.ToLower()))
                {
                    results.Add(orderItem);
                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menu, int? min, int? max)
        {
            if (min == null && max == null) return menu;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem orderItem in menu)
                {
                    if (orderItem.Calories <= max) results.Add(orderItem);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem orderItem in menu)
                {
                    if (orderItem.Calories >= min) results.Add(orderItem);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem orderItem in menu)
            {
                if (orderItem.Calories >= min && orderItem.Calories <= max)
                {
                    results.Add(orderItem);
                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menu, double? min, double? max)
        {
            if (min == null && max == null) return menu;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem orderItem in menu)
                {
                    if (orderItem.Price <= max) results.Add(orderItem);
                }
                return results;
            }
            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem orderItem in menu)
                {
                    if (orderItem.Price >= min) results.Add(orderItem);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem orderItem in menu)
            {
                if (orderItem.Price >= min && orderItem.Price <= max)
                {
                    results.Add(orderItem);
                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByItemTypes(IEnumerable<IOrderItem> menu, IEnumerable<string> itemTypes)
        {
            // If no filter is specified, just return the provided collection
            if (itemTypes == null || itemTypes.Count() == 0) return menu;
            // Filter the supplied collection of movies
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in menu)
            {
                if (itemTypes.Contains("Entrees") && item is Entree)
                {
                    results.Add(item);
                }
                else if (itemTypes.Contains("Sides") && item is Side)
                {
                    results.Add(item);
                }
                else if(itemTypes.Contains("Drinks") && item is Drink)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
