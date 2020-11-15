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

        private bool bacon = true;
        /// <summary>
        /// Property storing whether entree has bacon
        /// </summary>
        public bool Bacon
        {
            get
            {
                return bacon;
            }
            set
            {
                bacon = value;
                NotifyPropertyChanged("Bacon");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool bun = true;
        /// <summary>
        /// Property storing whether entree has a bun
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
        /// Property storing whether entree has cheese
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

        private bool egg = true;
        /// <summary>
        /// Property storing whether entree has an egg
        /// </summary>
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                egg = value;
                NotifyPropertyChanged("Egg");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// Property storing whether entree has ketchup
        /// </summary>
        public bool Ketchup
        {
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

        private bool lettuce = true;
        /// <summary>
        /// Property storing whether entree has lettuce
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                lettuce = value;
                NotifyPropertyChanged("Lettuce");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool mayo = true;
        /// <summary>
        /// Property storing whether entree has mayo
        /// </summary>
        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {
                mayo = value;
                NotifyPropertyChanged("Mayo");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// Property storing whether entree has mustard
        /// </summary>
        public bool Mustard
        {
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
        /// Property storing whether entree has pickle
        /// </summary>
        public bool Pickle
        {
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

        private bool tomato = true;
        /// <summary>
        /// Property storing whether entree has tomato
        /// </summary>
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                tomato = value;
                NotifyPropertyChanged("Tomato");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

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

        /// <summary>
        /// String describing the item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";
            }
        }
    }
}
