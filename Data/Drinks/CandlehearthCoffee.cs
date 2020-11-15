/*
 * Author: Connor Neil
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent a Candlehearth Coffee drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Object Class representing Candlehearth Coffee with all necessary properties for an accurate order
    /// </summary>
    public class CandlehearthCoffee : Drink , IOrderItem
    {
        private bool ice = false;
        /// <summary>
        /// Property holding whether the drink has ice
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
                NotifyPropertyChanged("Ice");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool decaf = false;
        /// <summary>
        /// Property holding whether the coffee is decaf
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
                NotifyPropertyChanged("Decaf");
                NotifyPropertyChanged("ToString");
            }
        }

        private bool roomForCream = false;
        /// <summary>
        /// Property holding whether to add cream to the coffee
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                roomForCream = value;
                NotifyPropertyChanged("RoomForCream");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }


        /// <summary>
        /// Property to get the price of the drink based on size
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 0.75;
                else if (Size == Size.Medium) return 1.25;
                else if (Size == Size.Large) return 1.75;
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
                if (Size == Size.Small) return 7;
                else if (Size == Size.Medium) return 10;
                else if (Size == Size.Large) return 20;
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
                if (Ice) instructions.Add("Add ice");
                if (RoomForCream) instructions.Add("Add cream");
                return instructions;
            }

        }

        /// <summary>
        /// String override to provide information about the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (!Decaf) return $"{Size} Candlehearth Coffee";
            else return $"{Size} Decaf Candlehearth Coffee";
        }

        /// <summary>
        /// String describing the item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Fair trade, fresh ground dark roast coffee.";
            }
        }
    }
}
