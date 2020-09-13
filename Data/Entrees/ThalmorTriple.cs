/*
 * Author: Connor Neil
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the Thalmor Triple, an absolutely massive burger.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Object Class representing a Thalmor Triple with all necessary properties for an accurate order
    /// </summary>
    public class ThalmorTriple : Entree , IOrderItem
    {
        /// <summary>
        /// Property storing whether entree has bacon
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Property storing whether entree has a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// Property storing whether entree has cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Property storing whether entree has an egg
        /// </summary>
        public bool Egg { get; set; } = true;

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
        /// price of the Thalmor Triple
        /// </summary>
        public override double Price => 8.32;

        /// <summary>
        /// Calories of a Thalmor Triple (too many)
        /// </summary>
        public override uint Calories => 943;

        /// <summary>
        /// Special Instruction list property storing all applicable special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Bun) instructions.Add("Hold bun");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Egg) instructions.Add("Hold egg");
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
            return "Thalmor Triple";
        }
    }
}
