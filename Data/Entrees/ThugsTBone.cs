/*
 * Author: Connor Neil
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent a Thugs T-Bone, the juiciest of the juicy
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Object Class representing a Thugs T-Bone with all necessary properties for an accurate order
    /// </summary>
    public class ThugsTBone : Entree, IOrderItem
    {
        /// <summary>
        /// price of the Thugs T-Bone
        /// </summary>
        public override double Price => 6.44;

        /// <summary>
        /// Calories of a Thugs T-Bone (if you thought the Triple was high you clearly haven't seen one of these bad boys)
        /// </summary>
        public override uint Calories => 982;

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
        /// String override to output name of the Entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
