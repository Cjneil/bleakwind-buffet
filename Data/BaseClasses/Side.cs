/* 
 * Author: Connor Neil
 * Class name: Side.cs
 * Class  used to represent a basic side for all sides on the menu to inherit and implement
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{

    /// <summary>
    /// A base class representing a size and its common properties
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for the change of any property within the class
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private backing variable for property Size
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// The size of the side
        /// </summary>
        public virtual Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs ("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ToString"));
            }
        }

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

        /// <summary>
        /// Help method to call property changed event within derived classes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}