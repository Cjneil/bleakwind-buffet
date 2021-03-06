﻿/*
 * Author: Connor Neil
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent Fried Miraak hash brown pancakes
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Object Class representing Fried Miraak with all necessary properties for an accurate order
    /// </summary>
    public class FriedMiraak : Side , IOrderItem
    {

        /// <summary>
        /// Property to get the price of the side based on size
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 1.78;
                else if (Size == Size.Medium) return 2.01;
                else if (Size == Size.Large) return 2.88;
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
                if (Size == Size.Small) return 151;
                else if (Size == Size.Medium) return 236;
                else if (Size == Size.Large) return 306;
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
            return $"{Size} Fried Miraak";
        }

        /// <summary>
        /// String describing the item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Perfectly prepared hash brown pancakes.";
            }
        }
    }
}
