/*
 * Author: Connor Neil
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent a Sailor Soda drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Object Class representing Sailor Soda with all necessary properties for an accurate order
    /// </summary>
    public class SailorSoda : Drink , IOrderItem
    {
        /// <summary>
        /// Private backing variable for Flavor
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;
        /// <summary>
        /// Property holding the flavor of the soda
        /// </summary>
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyPropertyChanged("Flavor");
                NotifyPropertyChanged("ToString");
            }
        }

        /// <summary>
        /// Private backing variable for Ice
        /// </summary>
        private bool ice = true;
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


        /// <summary>
        /// Property to get the price of the drink based on size
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Size.Small) return 1.42;
                else if (Size == Size.Medium) return 1.74;
                else if (Size == Size.Large) return 2.07;
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
                if (Size == Size.Small) return 117;
                else if (Size == Size.Medium) return 153;
                else if (Size == Size.Large) return 205;
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
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }

        }

        /// <summary>
        /// String override to provide information about the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }

        /// <summary>
        /// String describing the item
        /// </summary>
        public override string Description
        {
            get
            {
                return "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";
            }
        }
    }
}
