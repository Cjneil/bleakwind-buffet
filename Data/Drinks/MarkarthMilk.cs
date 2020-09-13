/*
 * Author: Connor Neil
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent a Markarth Milk drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Object Class representing Markarth Milk with all necessary properties for an accurate order
    /// </summary>
    public class MarkarthMilk : Drink, IOrderItem
    {
        /// <summary>
        /// Property holding whether the drink has ice
        /// </summary>
        public bool Ice { get; set; } = false;


        /// <summary>
        /// Property to get the price of the drink based on size
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 1.05;
                else if (Size == Size.Medium) return 1.11;
                else if (Size == Size.Large) return 1.22;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Property to get the calories of the drink based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) return 56;
                else if (Size == Size.Medium) return 72;
                else if (Size == Size.Large) return 93;
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
                if(Ice) instructions.Add("Add ice");
                return instructions;
            }

        }

        /// <summary>
        /// String override to provide information about the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Markarth Milk";
        }
    }
}
