/* 
 * Author: Connor Neil
 * Class name: Entree.cs
 * Class  used to represent a basic entree for all entrees on the menu to inherit
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{

    /// <summary>
    /// A base class representing an entree and its common properties
    /// </summary>
    public abstract class Entree :IOrderItem 
    {

        /// <summary>
        /// Price of the entree
        /// </summary>
        /// <value>
        /// in USD
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the entree stored in a list
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
