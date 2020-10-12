/*
 * Author: Zachery Brunner
 * Modified by: Connor Neil
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            Assert.IsAssignableFrom<Side>(new VokunSalad());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            Assert.IsAssignableFrom<IOrderItem>(new VokunSalad());
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new VokunSalad());
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var VS = new VokunSalad();
            Assert.Equal(Size.Small, VS.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var VS = new VokunSalad();
            VS.Size = Size.Small;
            Assert.Equal(Size.Small, VS.Size);
            VS.Size = Size.Medium;
            Assert.Equal(Size.Medium, VS.Size);
            VS.Size = Size.Large;
            Assert.Equal(Size.Large, VS.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var VS = new VokunSalad();
            Assert.Empty(VS.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var VS = new VokunSalad()
            {
                Size = size
            };
            Assert.Equal(price, VS.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var VS = new VokunSalad()
            {
                Size = size
            };
            Assert.Equal(calories, VS.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var VS = new VokunSalad()
            {
                Size = size
            };
            Assert.Equal(name, VS.ToString());
        }

        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedSize()
        {
            var VS = new VokunSalad();
            Assert.PropertyChanged(VS, "Size", () => {
                VS.Size = Size.Medium;
            });
        }

        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedPrice()
        {
            var VS = new VokunSalad();
            Assert.PropertyChanged(VS, "Price", () => {
                VS.Size = Size.Medium;
            });
        }

        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedCalories()
        {
            var VS = new VokunSalad();
            Assert.PropertyChanged(VS, "Calories", () => {
                VS.Size = Size.Medium;
            });
        }

        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedToString()
        {
            var VS = new VokunSalad();
            Assert.PropertyChanged(VS, "ToString", () => {
                VS.Size = Size.Medium;
            });
        }
    }
}