/*
 * Author: Connor Neil
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent a BriarHeart Burger object
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Object Class representing a Briarheart Burger with all necessary properties for an accurate order
    /// </summary>
    public class BriarheartBurger : Entree , IOrderItem
    {

        private bool bun = true;
        /// <summary>
        /// Property storing whether burger has a bun
        /// </summary>
        public bool Bun
        {
            get
            {
                return bun;
            }
            set
            {
                bun = value;
                NotifyPropertyChanged("Bun");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool cheese = true;
        /// <summary>
        /// Property storing whether burger has cheese
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                cheese = value;
                NotifyPropertyChanged("Cheese");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }


        private bool ketchup = true;
        /// <summary>
        /// Property storing whether burger has ketchup
        /// </summary>
        public bool Ketchup {
            get
            {
                return ketchup;
            }
            set
            {
                ketchup = value;
                NotifyPropertyChanged("Ketchup");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// Property storing whether burger has mustard
        /// </summary>
        public bool Mustard {
            get
            {
                return mustard;
            }
            set
            {
                mustard = value;
                NotifyPropertyChanged("Mustard");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// Property storing whether burger has pickle
        /// </summary>
        public bool Pickle {
            get
            {
                return pickle;
            }
            set
            {
                pickle = value;
                NotifyPropertyChanged("Pickle");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// price of the Briarheart Burger
        /// </summary>
        public override double Price => 6.32;

        /// <summary>
        /// Calories of a Briarheart Burger
        /// </summary>
        public override uint Calories => 743;

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
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                return instructions;
            }

        }

        /// <summary>
        /// String override to output name of the Entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }

        /// <summary>
        /// String describing the item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Single patty burger on a brioche bun. Comes with ketchup, mustard, pickle, and cheese.";
            }
        }
    }
}
