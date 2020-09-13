/*
 * Author: Connor Neil
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent a Double Draugr burger
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Object Class representing a Double Draugr burger with all necessary properties for an accurate order
    /// </summary>
    public class DoubleDraugr : Entree , IOrderItem
    {
        /// <summary>
        /// Property storing whether entree has a brioche bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Property storing whether entree has cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Property storing whether entree has ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// Property storing whether entree has lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Property storing whether entree has mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// Property storing whether entree has mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// Property storing whether entree has pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// Property storing whether entree has tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// price of the Double Draugr
        /// </summary>
        public override double Price => 7.32;

        /// <summary>
        /// Calories of a Double Draugr
        /// </summary>
        public override uint Calories => 843;

        /// <summary>
        /// Special Instruction list property storing all applicable special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bun) instructions.Add("Hold bun");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
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
            return "Double Draugr";
        }
    }
}
