/*
 * Author: Zachery Brunner
 * Modified by: Connor Neil
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var CH = new CandlehearthCoffee();
            Assert.False(CH.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            var CH = new CandlehearthCoffee();
            Assert.False(CH.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            var CH = new CandlehearthCoffee();
            Assert.False(CH.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var CH = new CandlehearthCoffee();
            Assert.Equal(Size.Small, CH.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var CH = new CandlehearthCoffee();
            CH.Ice = true;
            Assert.True(CH.Ice);
            CH.Ice = false;
            Assert.False(CH.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            var CH = new CandlehearthCoffee();
            CH.Decaf = true;
            Assert.True(CH.Decaf);
            CH.Decaf = false;
            Assert.False(CH.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            var CH = new CandlehearthCoffee();
            CH.RoomForCream = true;
            Assert.True(CH.RoomForCream);
            CH.RoomForCream = false;
            Assert.False(CH.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var CH = new CandlehearthCoffee();
            CH.Size = Size.Small;
            Assert.Equal(Size.Small, CH.Size);
            CH.Size = Size.Medium;
            Assert.Equal(Size.Medium, CH.Size);
            CH.Size = Size.Large;
            Assert.Equal(Size.Large, CH.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var CH = new CandlehearthCoffee()
            {
                Size = size
            };
            Assert.Equal(price, CH.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var CH = new CandlehearthCoffee()
            {
                Size = size
            };
            Assert.Equal(cal, CH.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            var CH = new CandlehearthCoffee()
            {
                Ice = includeIce,
                RoomForCream = includeCream
            };

            if (includeIce) Assert.Contains("Add ice", CH.SpecialInstructions);
            if (includeCream) Assert.Contains("Add cream", CH.SpecialInstructions);
            if (!includeCream && !includeIce) Assert.Empty(CH.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            var CH = new CandlehearthCoffee()
            {
                Decaf = decaf,
                Size = size
            };
            Assert.Equal(name, CH.ToString());
        }
    }
}
