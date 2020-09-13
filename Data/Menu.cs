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
                FriedMiraak f = new FriedMiraak();
                f.Size = size;
                MadOtarGrits m = new MadOtarGrits();
                m.Size = size;
                VokunSalad v = new VokunSalad();
                v.Size = size;
                sidesList.Add(d);
                sidesList.Add(f);
                sidesList.Add(m);
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
                CandlehearthCoffee c = new CandlehearthCoffee();
                c.Size = size;
                drinkList.Add(c);
                MarkarthMilk m = new MarkarthMilk();
                m.Size = size;
                drinkList.Add(m);
                foreach (SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda s = new SailorSoda();
                    s.Size = size;
                    s.Flavor = flavor;
                    drinkList.Add(s);
                }
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
    }
}
