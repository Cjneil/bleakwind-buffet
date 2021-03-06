﻿/*
 * Author: Connor Neil
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Dragonborn Waffle Fries side
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Object Class representing Dragonborn Waffle Fries with all necessary properties for an accurate order
    /// </summary>
    public class DragonbornWaffleFries : Side , IOrderItem
    {

        /// <summary>
        /// Property to get the price of the side based on size
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 0.42;
                else if (Size == Size.Medium) return 0.76;
                else if (Size == Size.Large) return 0.96;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Property to get the calories of the side based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 77;
                else if (Size == Size.Medium) return 89;
                else if (Size == Size.Large) return 100;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Special Instruction list property storing all applicable special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }

        }

        /// <summary>
        /// String override to provide information about the side
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }

        /// <summary>
        /// String describing the item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Crispy fried potato waffle fries.";
            }
        }
    }
}
