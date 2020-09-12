/*
 * Author: Zachery Brunner
 * Modified by: Connor Neil
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var OG = new MadOtarGrits();
            Assert.Equal(Size.Small, OG.Size);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var OG = new MadOtarGrits();
            OG.Size = Size.Small;
            Assert.Equal(Size.Small, OG.Size);
            OG.Size = Size.Medium;
            Assert.Equal(Size.Medium, OG.Size);
            OG.Size = Size.Large;
            Assert.Equal(Size.Large, OG.Size);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            var OG = new MadOtarGrits();
            Assert.Empty(OG.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var OG = new MadOtarGrits()
            {
                Size = size
            };
            Assert.Equal(price, OG.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var OG = new MadOtarGrits()
            {
                Size = size
            };
            Assert.Equal(calories, OG.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var OG = new MadOtarGrits()
            {
                Size = size
            };
            Assert.Equal(name, OG.ToString());
        }
    }
}