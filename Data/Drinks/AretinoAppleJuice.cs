/*
 * Author: Connor Neil
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent an Aretino Apple Juice drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Object Class representing Aretino Apple Juice with all necessary properties for an accurate order
    /// </summary>
    public class AretinoAppleJuice : Drink, IOrderItem
    {
        /// <summary>
        /// backing variable for Ice
        /// </summary>
        private bool ice = false;
        /// <summary>
        /// Property holding whether the drink has ice
        /// Note that this is consistent with UML guideline but results in a necessary change of Add Ice to Hold Ice 
        /// which is contradictory to assignment description
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
                if (Size == Size.Small) return 0.62;
                else if (Size == Size.Medium) return 0.87;
                else if (Size == Size.Large) return 1.01;
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
                if (Size == Size.Small) return 44;
                else if (Size == Size.Medium) return 88;
                else if (Size == Size.Large) return 132;
                else throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Special Instruction list property storing all applicable special instructions
        /// Note that Hold Ice was changed to represent the opposite of default state given in the UML. This is inconsistent with
        /// the assignment description that stated default of false and add ice if true for Ice while UML stated true
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }

        }

        /// <summary>
        /// String override to provide information about the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }
    }
}
