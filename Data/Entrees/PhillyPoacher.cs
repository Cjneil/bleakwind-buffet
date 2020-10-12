/*
 * Author: Connor Neil
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent a Philly Poacher philly cheesesteak
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Object Class representing Philly Poacher with all necessary properties for an accurate order
    /// </summary>
    public class PhillyPoacher : Entree, IOrderItem
    {
        private bool onion = true;
        /// <summary>
        /// Property storing whether entree has onions
        /// </summary>
        public bool Onion
        {
            get
            {
                return onion;
            }
            set
            {
                onion = value;
                NotifyPropertyChanged("Onion");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool roll = true;
        /// <summary>
        /// Property storing whether entree uses roll
        /// </summary>
        public bool Roll
        {
            get
            {
                return roll;
            }
            set
            {
                roll = value;
                NotifyPropertyChanged("Roll");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool sirloin = true;
        /// <summary>
        /// Property storing whether entree uses sirloin
        /// </summary>
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }
            set
            {
                sirloin = value;
                NotifyPropertyChanged("Sirloin");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// price of the Philly Poacher
        /// </summary>
        public override double Price => 7.23;

        /// <summary>
        /// Calories of a Philly Poacher
        /// </summary>
        public override uint Calories => 784;

        /// <summary>
        /// Special Instruction list property storing all applicable special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Onion) instructions.Add("Hold onions");
                if (!Roll) instructions.Add("Hold roll");
                if (!Sirloin) instructions.Add("Hold sirloin");
                return instructions;
            }
        }

        /// <summary>
        /// String override to output name of the Entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
