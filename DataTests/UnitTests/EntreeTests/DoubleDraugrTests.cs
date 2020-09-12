﻿/*
 * Author: Zachery Brunner
 * Modified by: Connor Neil
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {   
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            var DD = new DoubleDraugr();
            Assert.True(DD.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            var DD = new DoubleDraugr();
            Assert.True(DD.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            var DD = new DoubleDraugr();
            Assert.True(DD.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            var DD = new DoubleDraugr();
            Assert.True(DD.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            var DD = new DoubleDraugr();
            Assert.True(DD.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            var DD = new DoubleDraugr();
            Assert.True(DD.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            var DD = new DoubleDraugr();
            Assert.True(DD.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            var DD = new DoubleDraugr();
            Assert.True(DD.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            var DD = new DoubleDraugr();
            DD.Bun = true;
            Assert.True(DD.Bun);
            DD.Bun = false;
            Assert.False(DD.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            var DD = new DoubleDraugr();
            DD.Ketchup = true;
            Assert.True(DD.Ketchup);
            DD.Ketchup = false;
            Assert.False(DD.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            var DD = new DoubleDraugr();
            DD.Mustard = true;
            Assert.True(DD.Mustard);
            DD.Mustard = false;
            Assert.False(DD.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            var DD = new DoubleDraugr();
            DD.Pickle = true;
            Assert.True(DD.Pickle);
            DD.Pickle = false;
            Assert.False(DD.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            var DD = new DoubleDraugr();
            DD.Cheese = true;
            Assert.True(DD.Cheese);
            DD.Cheese = false;
            Assert.False(DD.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var DD = new DoubleDraugr();
            DD.Tomato = true;
            Assert.True(DD.Tomato);
            DD.Tomato = false;
            Assert.False(DD.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            var DD = new DoubleDraugr();
            DD.Lettuce = true;
            Assert.True(DD.Lettuce);
            DD.Lettuce = false;
            Assert.False(DD.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            var DD = new DoubleDraugr();
            DD.Mayo = true;
            Assert.True(DD.Mayo);
            DD.Mayo = false;
            Assert.False(DD.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var DD = new DoubleDraugr();
            Assert.Equal(7.32, DD.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var DD = new DoubleDraugr();
            Assert.Equal(843u, DD.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            var DD = new DoubleDraugr()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo
            };
            if (!includeBun) Assert.Contains("Hold bun", DD.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", DD.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", DD.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", DD.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", DD.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", DD.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", DD.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", DD.SpecialInstructions);
            if (includeBun && includeCheese && includeKetchup && includeLettuce && includeMayo && includeMustard && includePickle && includeTomato) Assert.Empty(DD.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var DD = new DoubleDraugr();
            Assert.Equal("Double Draugr", DD.ToString());
        }
    }
}