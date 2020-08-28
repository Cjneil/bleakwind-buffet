/*
 * Author: Connor Neil
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent Mad Otar cheesy grits
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Object Class representing Mad Otar Grits with all necessary properties for an accurate order
    /// </summary>
    public class MadOtarGrits
    {
        /// <summary>
        /// Property holding the size of the side
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Property to get the price of the side based on size
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Size.Small) return 1.22;
                else if (Size == Size.Medium) return 1.58;
                else if (Size == Size.Large) return 1.93;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Property to get the calories of the side based on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 105;
                else if (Size == Size.Medium) return 142;
                else if (Size == Size.Large) return 179;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Special Instruction list property storing all applicable special instructions
        /// </summary>
        public List<string> SpecialInstructions
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
            return $"{Size} Mad Otar Grits";
        }
    }
}
