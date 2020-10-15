/*
 * Author: Zachery Brunner
 * Modified by: Connor Neil
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    { 
        [Fact]
        public void ShouldBeADrink()
        {
            Assert.IsAssignableFrom<Drink>(new MarkarthMilk());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            Assert.IsAssignableFrom<IOrderItem>(new MarkarthMilk());
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new MarkarthMilk());
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var MK = new MarkarthMilk();
            Assert.False(MK.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var MK = new MarkarthMilk();
            Assert.Equal(Size.Small, MK.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var MK = new MarkarthMilk();
            MK.Ice = true;
            Assert.True(MK.Ice);
            MK.Ice = false;
            Assert.False(MK.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var MK = new MarkarthMilk();
            MK.Size = Size.Small;
            Assert.Equal(Size.Small, MK.Size);
            MK.Size = Size.Medium;
            Assert.Equal(Size.Medium, MK.Size);
            MK.Size = Size.Large;
            Assert.Equal(Size.Large, MK.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var MK = new MarkarthMilk()
            {
                Size = size
            };
            Assert.Equal(price, MK.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var MK = new MarkarthMilk()
            {
                Size = size
            };
            Assert.Equal(cal, MK.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var MK = new MarkarthMilk()
            {
                Ice = includeIce
            };

            if (includeIce) Assert.Contains("Add ice", MK.SpecialInstructions);
            else Assert.Empty(MK.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var MK = new MarkarthMilk()
            {
                Size = size
            };
            Assert.Equal(name, MK.ToString());
        }

        [Fact]
        public void IceChangeShouldTriggerPropertyChangedIce()
        {
            var MK = new MarkarthMilk();
            Assert.PropertyChanged(MK, "Ice", () => {
                MK.Ice = true;
            });
        }

        [Fact]
        public void IceChangeShouldTriggerPropertyChangedSpecialInstructions()
        {
            var MK = new MarkarthMilk();
            Assert.PropertyChanged(MK, "SpecialInstructions", () => {
                MK.Ice = true;
            });
        }

        [Fact]
        public void IceChangeShouldTriggerPropertyChangedInstructions()
        {
            var MK = new MarkarthMilk();
            Assert.PropertyChanged(MK, "Instructions", () => {
                MK.Ice = true;
            });
        }
    }
}