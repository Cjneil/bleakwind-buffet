/*
 * Author: Connor Neil
 * Class: DrinkTests.cs
 * Purpose: Test the Drink.cs class in the Data library
 * Anything tested in here will by definition work on any Drink object in the project
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class DrinkTests
    {
        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedName()
        {
            Drink AJ = new AretinoAppleJuice();
            Assert.PropertyChanged(AJ, "Name", () => {
                AJ.Size = Size.Medium;
            });
        }

        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedSize()
        {
            Drink AJ = new AretinoAppleJuice();
            Assert.PropertyChanged(AJ, "Size", () => {
                AJ.Size = Size.Medium;
            });
        }

        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedPrice()
        {
            Drink AJ = new AretinoAppleJuice();
            Assert.PropertyChanged(AJ, "Price", () => {
                AJ.Size = Size.Medium;
            });
        }

        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedCalories()
        {
            Drink AJ = new AretinoAppleJuice();
            Assert.PropertyChanged(AJ, "Calories", () => {
                AJ.Size = Size.Medium;
            });
        }

        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedToString()
        {
            Drink AJ = new AretinoAppleJuice();
            Assert.PropertyChanged(AJ, "ToString", () => {
                AJ.Size = Size.Medium;
            });
        }
    }
}
