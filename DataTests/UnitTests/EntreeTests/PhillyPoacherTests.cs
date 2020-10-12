/*
 * Author: Zachery Brunner
 * Modified by: Connor Neil
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            Assert.IsAssignableFrom<Entree>(new PhillyPoacher());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            Assert.IsAssignableFrom<IOrderItem>(new PhillyPoacher());
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new PhillyPoacher());
        }

        [Fact]
        public void ShouldIncludeSirloinByDefault()
        {
            var PO = new PhillyPoacher();
            Assert.True(PO.Sirloin);
        }

        [Fact]
        public void ShouldIncludeOnionByDefault()
        {
            var PO = new PhillyPoacher();
            Assert.True(PO.Onion);
        }

        [Fact]
        public void ShouldIncludeRollByDefault()
        {
            var PO = new PhillyPoacher();
            Assert.True(PO.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            var PO = new PhillyPoacher();
            PO.Sirloin = true;
            Assert.True(PO.Sirloin);
            PO.Sirloin = false;
            Assert.False(PO.Sirloin);
        }

        [Fact]
        public void SirloinChangeShouldTriggerPropertyChangedSirloinAndSpecialInstructions()
        {
            var PO = new PhillyPoacher();
            Assert.PropertyChanged(PO, "Sirloin", () => {
                PO.Sirloin = false;
            });
            Assert.PropertyChanged(PO, "SpecialInstructions", () => {
                PO.Sirloin = true;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            var PO = new PhillyPoacher();
            PO.Onion = true;
            Assert.True(PO.Onion);
            PO.Onion = false;
            Assert.False(PO.Onion);
        }

        [Fact]
        public void OnionChangeShouldTriggerPropertyChangedOnionAndSpecialInstructions()
        {
            var PO = new PhillyPoacher();
            Assert.PropertyChanged(PO, "Onion", () => {
                PO.Onion = false;
            });
            Assert.PropertyChanged(PO, "SpecialInstructions", () => {
                PO.Onion = true;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            var PO = new PhillyPoacher();
            PO.Roll = true;
            Assert.True(PO.Roll);
            PO.Roll = false;
            Assert.False(PO.Roll);
        }

        [Fact]
        public void RollChangeShouldTriggerPropertyChangedRollAndSpecialInstructions()
        {
            var PO = new PhillyPoacher();
            Assert.PropertyChanged(PO, "Roll", () => {
                PO.Roll = false;
            });
            Assert.PropertyChanged(PO, "SpecialInstructions", () => {
                PO.Roll = true;
            });
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var PO = new PhillyPoacher();
            Assert.Equal(7.23, PO.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var PO = new PhillyPoacher();
            Assert.Equal(784u, PO.Calories);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            var PO = new PhillyPoacher()
            {
                Sirloin = includeSirloin,
                Onion = includeOnion,
                Roll = includeRoll
            };
            if (!includeOnion) Assert.Contains("Hold onions", PO.SpecialInstructions);
            if (!includeRoll) Assert.Contains("Hold roll", PO.SpecialInstructions);
            if (!includeSirloin) Assert.Contains("Hold sirloin", PO.SpecialInstructions);
            if (includeOnion && includeRoll && includeSirloin) Assert.Empty(PO.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var PO = new PhillyPoacher();
            Assert.Equal("Philly Poacher", PO.ToString());
        }
    }
}