/*
 * Author: Zachery Brunner
 * Modified by: Connor Neil
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            Assert.IsAssignableFrom<Side>(new FriedMiraak());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            Assert.IsAssignableFrom<IOrderItem>(new FriedMiraak());
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var FM = new FriedMiraak();
            Assert.Equal(Size.Small, FM.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var FM = new FriedMiraak();
            FM.Size = Size.Small;
            Assert.Equal(Size.Small, FM.Size);
            FM.Size = Size.Medium;
            Assert.Equal(Size.Medium, FM.Size);
            FM.Size = Size.Large;
            Assert.Equal(Size.Large, FM.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var FM = new FriedMiraak();
            Assert.Empty(FM.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var FM = new FriedMiraak()
            {
                Size = size
            };
            Assert.Equal(price, FM.Price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var FM = new FriedMiraak()
            {
                Size = size
            };
            Assert.Equal(calories, FM.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var FM = new FriedMiraak()
            {
                Size = size
            };
            Assert.Equal(name, FM.ToString());
        }
    }
}