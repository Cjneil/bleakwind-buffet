/* 
 * Author: Connor Neil
 * Class name: IOrderItem.cs
 * Purpose: Interface creating a sharable type for all items on the Bleakwind Buffet menu
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interface indicating that an item is meant to be orderable
    /// and must require a price, calories, and list of special instructions
    /// </summary>
    public interface IOrderItem: INotifyPropertyChanged
    {
        /// <summary>
        /// Represents that any OrderItem must have a price
        /// </summary>
        /// <value>
        /// Price in USD
        /// </value>
        double Price { get; }

        /// <summary>
        /// Represents that any OrderItem must have a known Calories value
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Represents that any OrderItem must have a list of special instructions to prepare the order (may be empty)
        /// </summary>
        List<string> SpecialInstructions { get; }

    }
}
