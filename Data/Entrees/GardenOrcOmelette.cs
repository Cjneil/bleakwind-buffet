/*
 * Author: Connor Neil
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette, a vegetarian omelette.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Object Class representing a Garden Orc Omelette with all necessary properties for an accurate order
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem
    {
        /// <summary>
        /// Property storing whether entree has a broccoli
        /// </summary>
        public bool Broccoli { get; set; } = true;

        /// <summary>
        /// Property storing whether entree has cheddar
        /// </summary>
        public bool Cheddar { get; set; } = true;

        /// <summary>
        /// Property storing whether entree has mushrooms
        /// </summary>
        public bool Mushrooms { get; set; } = true;

        /// <summary>
        /// Property storing whether entree has tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// price of the Garden Orc Omelette
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// Calories of a Garden Orc Omelette
        /// </summary>
        public override uint Calories => 404;

        /// <summary>
        /// Special Instruction list property storing all applicable special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Broccoli) instructions.Add("Hold broccoli");
                if (!Cheddar) instructions.Add("Hold cheddar");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato) instructions.Add("Hold tomato");
                return instructions;
            }
        }

        /// <summary>
        /// String override to output name of the Entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
