﻿/*
 * Author: Connor Neil
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent a Warrior Water drink
 */
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Object Class representing Warrior Water with all necessary properties for an accurate order
    /// </summary>
    public class WarriorWater
    {
        /// <summary>
        /// Property holding whether the drink has ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Property holding whether the water should have a lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Property holding the size of the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Property to get the price of the drink based on size
        /// </summary>
        public double Price => 0;

        /// <summary>
        /// Property to get the calories of the drink based on size
        /// </summary>
        public uint Calories => 0;

        /// <summary>
        /// Special Instruction list property storing all applicable special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (!Ice) instructions.Add("Hold ice");
                if (Lemon) instructions.Add("Add lemon");
                return instructions;
            }

        }

        /// <summary>
        /// String override to provide information about the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }
    }
}