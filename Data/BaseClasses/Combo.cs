/* 
 * Author: Connor Neil
 * Class name: Combo.cs
 * Class  used to represent a combo consisting of a Drink, Entree, and Side
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// IOrderItem composed of the IOrderItems Entree, Drink, and Side
    /// </summary>
    public class Combo: IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// Event for any properties that change within the object
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// default constructor for a combo object
        /// </summary>
        /// <param name="drink">Drink to be used in combo</param>
        /// <param name="entree">Entree to be used in combo</param>
        /// <param name="side">Side to be used in combo</param>
        public Combo(Drink drink, Entree entree, Side side)
        {
            this.Drink = drink; 
            this.Entree = entree;
            this.Side = side;
        }

        /// <summary>
        /// The drink of the combo
        /// </summary>
        private Drink drink;
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                if (drink != null)
                {
                    drink.PropertyChanged -= SubItemPropertyChanged;
                }
                    drink = value;
                    drink.PropertyChanged += SubItemPropertyChanged;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Instructions"));
            }
        }

        /// <summary>
        /// The Entree of the combo
        /// </summary>
        private Entree entree;

        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                if (entree != null)
                {
                    entree.PropertyChanged -= SubItemPropertyChanged;
                }
                    entree = value;
                    entree.PropertyChanged += SubItemPropertyChanged;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Instructions"));
            }
        }

        /// <summary>
        /// The side of the combo
        /// </summary>
        private Side side;

        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                if (side != null)
                {
                    side.PropertyChanged -= SubItemPropertyChanged;
                }
                    side = value;
                    side.PropertyChanged += SubItemPropertyChanged;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Instructions"));
            }
        }

        /// <summary>
        /// Property to get the total price of the Entree, Drink, and Side
        /// </summary>
        public double Price
        {
            get
            {
                    return (drink.Price + entree.Price + side.Price - 1);
                
            }
        }

        /// <summary>
        /// Property to get the total Calories of the Entree, Drink, and Side
        /// </summary>
        public uint Calories
        {
            get
            {
                return (drink.Calories + entree.Calories + side.Calories);
            }
        }

        public string Name
        {
            get 
            { 
                return "Combo"; 
            }
        }
        /// <summary>
        /// Instructions in string form as a property to watch for PropertyChangeEvents
        /// For potential later use. Please ignore
        /// </summary>
        public string Instructions
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (string s in SpecialInstructions)
                {
                    if (s.Equals(Entree.ToString())) sb.Append("   " + Entree.ToString() + "\n");
                    else if (s.Equals(Side.ToString())) sb.Append("\n   " + Side.ToString() + "\n");
                    else if (s.Equals(Drink.ToString())) sb.Append("\n   " + Drink.ToString() + "\n");
                    else sb.Append("      - " + s + "\n");
                }
                return sb.ToString();
            }
        }
        /// <summary>
        /// Special Instruction list property storing the Special Instructions for all items in the combo
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                instructions.Add(Entree.ToString());
                instructions.AddRange(Entree.SpecialInstructions);
                instructions.Add(Side.ToString());
                instructions.AddRange(Side.SpecialInstructions);
                instructions.Add(Drink.ToString());
                instructions.AddRange(Drink.SpecialInstructions);
                return instructions;
            }
        }

        /// <summary>
        /// Handles the PropertyChanged event 
        /// For use with listeners on individual items within the combo to note 
        /// changes in their properties and invoke the correct event responses.
        /// </summary>
        /// <param name="source">Source of the event</param>
        /// <param name="e"> Property that changed</param>
        public void SubItemPropertyChanged(object source, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
            else if(e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
            else if (e.PropertyName == "SpecialInstructions") PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Instructions"));
        }


    }
}
