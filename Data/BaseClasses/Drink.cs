/* 
 * Author: Connor Neil
 * Class name: Drink.cs
 * Class  used to represent a basic Drink  for all drinks on the menu to inherit
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{

    /// <summary>
    /// A base class representing a drink and its common properties
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
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
        /// The size of the drink
        /// </summary>
        public virtual Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ToString"));
            }
        }

        /// <summary>
        /// ToString in Property form to use to invoke events when changed
        /// </summary>
        public virtual string Name
        {
            get => ToString();
        }

        /// <summary>
        /// Instructions in string form as a property to watch for PropertyChangeEvents
        /// </summary>
        public virtual string Instructions
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach(string s in SpecialInstructions)
                {
                    sb.Append("- " + s + "\n");
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// Price of the drink
        /// </summary>
        /// <value>
        /// in USD
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of the drink
        /// </summary>
        public abstract uint Calories { get; }
        
        /// <summary>
        /// Special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Helper method to call property changed event within derived classes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            if (propertyName.Equals("SpecialInstructions")) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Instructions"));
            if (propertyName.Equals("ToString")) PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));

        }

        /// <summary>
        /// String describing the item
        /// </summary>
        public abstract string Description { get; }
    }
}
