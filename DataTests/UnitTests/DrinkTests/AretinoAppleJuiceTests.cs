/*
 * Author: Zachery Brunner
 * Modified by: Connor Neil
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            Assert.IsAssignableFrom<Drink>(new AretinoAppleJuice());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            Assert.IsAssignableFrom<IOrderItem>(new AretinoAppleJuice());
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new AretinoAppleJuice());
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var AJ = new AretinoAppleJuice();
            Assert.False(AJ.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var AJ = new AretinoAppleJuice();
            Assert.Equal(Size.Small, AJ.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var AJ = new AretinoAppleJuice();
            AJ.Ice = true;
            Assert.True(AJ.Ice);
            AJ.Ice = false;
            Assert.False(AJ.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var AJ = new AretinoAppleJuice();
            AJ.Size = Size.Small;
            Assert.Equal(Size.Small, AJ.Size);
            AJ.Size = Size.Medium;
            Assert.Equal(Size.Medium, AJ.Size);
            AJ.Size = Size.Large;
            Assert.Equal(Size.Large, AJ.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var AJ = new AretinoAppleJuice()
            {
                Size = size
            };
            Assert.Equal(price, AJ.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var AJ = new AretinoAppleJuice()
            {
                Size = size
            };
            Assert.Equal(cal, AJ.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var AJ = new AretinoAppleJuice()
            {
                Ice = includeIce
            };

            if (includeIce) Assert.Contains("Add ice", AJ.SpecialInstructions);
            else Assert.Empty(AJ.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var AJ = new AretinoAppleJuice()
            {
                Size = size
            };
            Assert.Equal(name, AJ.ToString());
        }

        [Fact]
        public void IceChangeShouldTriggerPropertyChangedIce()
        {
            var AJ = new AretinoAppleJuice();
            Assert.PropertyChanged(AJ, "Ice", () => {
                AJ.Ice = true;
            });
        }

        [Fact]
        public void IceChangeShouldTriggerPropertyChangedSpecialInstructions()
        {
            var AJ = new AretinoAppleJuice();
            Assert.PropertyChanged(AJ, "SpecialInstructions", () => {
                AJ.Ice = true;
            });
        }

        [Fact]
        public void IceChangeShouldTriggerPropertyChangedInstructions()
        {
            var AJ = new AretinoAppleJuice();
            Assert.PropertyChanged(AJ, "Instructions", () => {
                AJ.Ice = true;
            });
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var AJ = new AretinoAppleJuice();
            Assert.Equal("Fresh squeezed apple juice.", AJ.Description);
        }
    }
}