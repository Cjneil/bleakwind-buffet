using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    public class FalmerFloat :IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private SodaFlavor flavor;
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public string Name
        {
            get => ToString();
        }


        /// <summary>
        /// Property to get the price of the drink based on size
        /// </summary>
        public double Price
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
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) return 117;
                else if (Size == Size.Medium) return 153;
                else if (Size == Size.Large) return 205;
                else throw new NotImplementedException();
            }
        }

        private Size size;
        /// <summary>
        /// The size of the drink
        /// </summary>
        public  Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Special Instruction list property storing all applicable special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }

        }

        public string Instructions => throw new NotImplementedException();

        /// <summary>
        /// String override to provide information about the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Falmer Float";
        }
    }
}
