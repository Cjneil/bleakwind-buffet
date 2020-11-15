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
        private bool broccoli = true;
        /// <summary>
        /// Property storing whether entree has a broccoli
        /// </summary>
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }
            set
            {
                broccoli = value;
                NotifyPropertyChanged("Broccoli");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool cheddar = true;
        /// <summary>
        /// Property storing whether entree has cheddar
        /// </summary>
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }
            set
            {
                cheddar = value;
                NotifyPropertyChanged("Cheddar");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool mushrooms = true;
        /// <summary>
        /// Property storing whether entree has mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }
            set
            {
                mushrooms = value;
                NotifyPropertyChanged("Mushrooms");
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

        /// <summary>
        /// String describing the item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";
            }
        }
    }
}
