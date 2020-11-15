/*
 * Author: Connor Neil
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent a Vokun fruit salad
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Object Class representing Vokun Salad with all necessary properties for an accurate order
    /// </summary>
    public class VokunSalad : Side , IOrderItem
    {

        /// <summary>
        /// Property to get the price of the side based on size
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 0.93;
                else if (Size == Size.Medium) return 1.28;
                else if (Size == Size.Large) return 1.82;
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
                if (Size == Size.Small) return 41;
                else if (Size == Size.Medium) return 52;
                else if (Size == Size.Large) return 73;
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
            return $"{Size} Vokun Salad";
        }

        /// <summary>
        /// String describing the item
        /// </summary>
        public override string Description
        {
            get
            {
                return "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.";
            }
        }
    }
}
