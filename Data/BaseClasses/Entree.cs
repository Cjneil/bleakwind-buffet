/* 
 * Author: Connor Neil
 * Class name: Entree.cs
 * Class  used to represent a basic entree for all entrees on the menu to inherit
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{

    /// <summary>
    /// A base class representing an entree and its common properties
    /// </summary>
    public abstract class Entree :IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for the change of any property within the class
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
                foreach (string s in SpecialInstructions)
                {
                    sb.Append("- " + s + "\n");
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// Special instructions to prepare the entree stored in a list
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
        }

        /// <summary>
        /// String describing the item
        /// </summary>
        public abstract string Description { get; }
    }
}
