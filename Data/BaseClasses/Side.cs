/* 
 * Author: Connor Neil
 * Class name: Side.cs
 * Class  used to represent a basic side for all sides on the menu to inherit and implement
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{

    /// <summary>
    /// A base class representing a size and its common properties
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// The size of the side
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Price of the side
        /// </summary>
        /// <value>
        /// in USD
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}