/*
 * Author: Connor Neil
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent a Smokehouse Skeleton breakfast combo
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Object Class representing a Smokehouse Skeleton combo with all necessary properties for an accurate order
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem
    {
        private bool egg = true;
        /// <summary>
        /// Property storing whether entree has a egg
        /// </summary>
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                egg = value;
                NotifyPropertyChanged("Egg");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool hashbrowns = true;
        /// <summary>
        /// Property storing whether entree has hash browns
        /// </summary>
        public bool HashBrowns
        {
            get
            {
                return hashbrowns;
            }
            set
            {
                hashbrowns = value;
                NotifyPropertyChanged("HashBrowns");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool pancake = true;
        /// <summary>
        /// Property storing whether entree has pancakes
        /// </summary>
        public bool Pancake
        {
            get
            {
                return pancake;
            }
            set
            {
                pancake = value;
                NotifyPropertyChanged("Pancake");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        private bool sausagelink = true;
        /// <summary>
        /// Property storing whether entree has sausage links
        /// </summary>
        public bool SausageLink
        {
            get
            {
                return sausagelink;
            }
            set
            {
                sausagelink = value;
                NotifyPropertyChanged("SausageLink");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// price of the Smokehouse Skeleton combo
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Calories of a Smokehouse Skeleton combo
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// Special Instruction list property storing all applicable special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Egg) instructions.Add("Hold eggs");
                if (!HashBrowns) instructions.Add("Hold hash browns");
                if (!Pancake) instructions.Add("Hold pancakes");
                if (!SausageLink) instructions.Add("Hold sausage");
                return instructions;
            }
        }

        /// <summary>
        /// String override to output name of the Entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }

        /// <summary>
        /// String describing the item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, and hash browns on the side. Topped with the syrup of your choice.";
            }
        }
    }
}
