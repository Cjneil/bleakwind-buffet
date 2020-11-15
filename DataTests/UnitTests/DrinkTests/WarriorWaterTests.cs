/*
 * Author: Connor Neil
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            Assert.IsAssignableFrom<Drink>(new WarriorWater());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            Assert.IsAssignableFrom<IOrderItem>(new WarriorWater());
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new WarriorWater());
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            var WW = new WarriorWater();
            Assert.True(WW.Ice);
        }

        [Fact]
        public void ShouldNotHaveLemonByDefault()
        {
            var WW = new WarriorWater();
            Assert.False(WW.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var WW = new WarriorWater();
            Assert.Equal(Size.Small, WW.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var WW = new WarriorWater();
            WW.Ice = true;
            Assert.True(WW.Ice);
            WW.Ice = false;
            Assert.False(WW.Ice);
        }
        
        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            var WW = new WarriorWater();
            WW.Lemon = true;
            Assert.True(WW.Lemon);
            WW.Lemon = false;
            Assert.False(WW.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var WW = new WarriorWater();
            WW.Size = Size.Small;
            Assert.Equal(Size.Small, WW.Size);
            WW.Size = Size.Medium;
            Assert.Equal(Size.Medium, WW.Size);
            WW.Size = Size.Large;
            Assert.Equal(Size.Large, WW.Size);

        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var WW = new WarriorWater()
            {
                Size = size
            };
            Assert.Equal(price, WW.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var WW = new WarriorWater()
            {
                Size = size
            };
            Assert.Equal(cal, WW.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            var WW = new WarriorWater()
            {
                Ice = includeIce,
                Lemon = includeLemon
            };
            if (!includeIce) Assert.Contains("Hold ice", WW.SpecialInstructions);
            if (includeLemon) Assert.Contains("Add lemon", WW.SpecialInstructions);
            if (includeIce && !includeLemon) Assert.Empty(WW.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var WW = new WarriorWater()
            {
                Size = size
            };
            Assert.Equal(name, WW.ToString());
        }

        [Fact]
        public void IceChangeShouldTriggerPropertyChangedIce()
        {
            var WW = new WarriorWater();
            Assert.PropertyChanged(WW, "Ice", () => {
                WW.Ice = true;
            });
        }

        [Fact]
        public void IceChangeShouldTriggerPropertyChangedSpecialInstructions()
        {
            var WW = new WarriorWater();
            Assert.PropertyChanged(WW, "SpecialInstructions", () => {
                WW.Ice = true;
            });
        }

        [Fact]
        public void IceChangeShouldTriggerPropertyChangedInstructions()
        {
            var WW = new WarriorWater();
            Assert.PropertyChanged(WW, "Instructions", () => {
                WW.Ice = true;
            });
        }

        [Fact]
        public void LemonChangeShouldTriggerPropertyChangedLemon()
        {
            var WW = new WarriorWater();
            Assert.PropertyChanged(WW, "Lemon", () => {
                WW.Lemon = true;
            });
        }

        [Fact]
        public void LemonChangeShouldTriggerPropertyChangedSpecialInstructions()
        {
            var WW = new WarriorWater();
            Assert.PropertyChanged(WW, "SpecialInstructions", () => {
                WW.Lemon = true;
            });
        }

        [Fact]
        public void LemonChangeShouldTriggerPropertyChangedInstructions()
        {
            var WW = new WarriorWater();
            Assert.PropertyChanged(WW, "Instructions", () => {
                WW.Lemon = true;
            });
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var WW = new WarriorWater();
            Assert.Equal("It’s water. Just water.", WW.Description);
        }
    }
}