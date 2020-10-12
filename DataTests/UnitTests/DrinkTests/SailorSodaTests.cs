/*
 * Author: Zachery Brunner
 * Modified by: Connor Neil
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            Assert.IsAssignableFrom<Drink>(new SailorSoda());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            Assert.IsAssignableFrom<IOrderItem>(new SailorSoda());
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new SailorSoda());
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            var SS = new SailorSoda();
            Assert.True(SS.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var SS = new SailorSoda();
            Assert.Equal(Size.Small, SS.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            var SS = new SailorSoda();
            Assert.Equal(SodaFlavor.Cherry, SS.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var SS = new SailorSoda();
            SS.Ice = true;
            Assert.True(SS.Ice);
            SS.Ice = false;
            Assert.False(SS.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var SS = new SailorSoda();
            SS.Size = Size.Small;
            Assert.Equal(Size.Small, SS.Size);
            SS.Size = Size.Medium;
            Assert.Equal(Size.Medium, SS.Size);
            SS.Size = Size.Large;
            Assert.Equal(Size.Large, SS.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            var SS = new SailorSoda();
            SS.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, SS.Flavor);
            SS.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, SS.Flavor);
            SS.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, SS.Flavor);
            SS.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, SS.Flavor);
            SS.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, SS.Flavor);
            SS.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, SS.Flavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var SS = new SailorSoda()
            {
                Size = size
            };
            Assert.Equal(price, SS.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var SS = new SailorSoda()
            {
                Size = size
            };
            Assert.Equal(cal, SS.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var SS = new SailorSoda() 
            { 
                Ice = includeIce
            };

            if (!includeIce) Assert.Contains("Hold ice", SS.SpecialInstructions);
            else Assert.Empty(SS.SpecialInstructions);
        }
        
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            var SS = new SailorSoda()
            {
                Flavor = flavor,
                Size = size
            };
            Assert.Equal(name, SS.ToString());
        }

        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedSize()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "Size", () => {
                SS.Size = Size.Medium;
            });
        }
        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedPrice()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "Price", () => {
                SS.Size = Size.Medium;
            });
        }

        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedCalories()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "Calories", () => {
                SS.Size = Size.Medium;
            });
        }
        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedToString()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "ToString", () => {
                SS.Size = Size.Medium;
            });
        }

        [Fact]
        public void IceChangeShouldTriggerPropertyChangedIce()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "Ice", () => {
                SS.Ice = true;
            });
        }

        [Fact]
        public void IceChangeShouldTriggerPropertyChangedSpecialInstructions()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "SpecialInstructions", () => {
                SS.Ice = true;
            });
        }

        [Fact]
        public void FlavorChangeShouldTriggerPropertyChangedFlavor()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "Flavor", () => {
                SS.Flavor = SodaFlavor.Grapefruit;
            });
        }

        [Fact]
        public void FlavorChangeShouldTriggerPropertyChangedToString()
        {
            var SS = new SailorSoda();
            Assert.PropertyChanged(SS, "ToString", () => {
                SS.Flavor = SodaFlavor.Grapefruit;
            });
        }
    }
}
