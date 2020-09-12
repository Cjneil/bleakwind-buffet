/*
 * Author: Zachery Brunner
 * Modified by: Connor Neil
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var DW = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, DW.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var DW = new DragonbornWaffleFries();
            DW.Size = Size.Small;
            Assert.Equal(Size.Small, DW.Size);
            DW.Size = Size.Medium;
            Assert.Equal(Size.Medium, DW.Size);
            DW.Size = Size.Large;
            Assert.Equal(Size.Large, DW.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var DW = new DragonbornWaffleFries();
            Assert.Empty(DW.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var DW = new DragonbornWaffleFries()
            {
                Size = size
            };
            Assert.Equal(price, DW.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var DW = new DragonbornWaffleFries()
            {
                Size = size
            };
            Assert.Equal(calories, DW.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var DW = new DragonbornWaffleFries()
            {
                Size = size
            };
            Assert.Equal(name, DW.ToString());
        }
    }
}