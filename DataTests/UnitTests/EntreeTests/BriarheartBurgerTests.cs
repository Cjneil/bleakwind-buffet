/*
 * Author: Zachery Brunner
 * Modified by: Connor Neil
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            var BB = new BriarheartBurger();
            Assert.True(BB.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            var BB = new BriarheartBurger();
            Assert.True(BB.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            var BB = new BriarheartBurger();
            Assert.True(BB.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            var BB = new BriarheartBurger();
            Assert.True(BB.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            var BB = new BriarheartBurger();
            Assert.True(BB.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            var BB = new BriarheartBurger();
            BB.Bun = true;
            Assert.True(BB.Bun);
            BB.Bun = false;
            Assert.False(BB.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            var BB = new BriarheartBurger();
            BB.Ketchup = true;
            Assert.True(BB.Ketchup);
            BB.Ketchup = false;
            Assert.False(BB.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            var BB = new BriarheartBurger();
            BB.Mustard = true;
            Assert.True(BB.Mustard);
            BB.Mustard = false;
            Assert.False(BB.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            var BB = new BriarheartBurger();
            BB.Pickle = true;
            Assert.True(BB.Pickle);
            BB.Pickle = false;
            Assert.False(BB.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            var BB = new BriarheartBurger();
            BB.Cheese = true;
            Assert.True(BB.Cheese);
            BB.Cheese = false;
            Assert.False(BB.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var BB = new BriarheartBurger();
            Assert.Equal(6.32, BB.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var BB = new BriarheartBurger();
            Assert.Equal(743u, BB.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            var BB = new BriarheartBurger()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese
            };
                
            if (!includeBun) Assert.Contains("Hold bun", BB.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", BB.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", BB.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", BB.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", BB.SpecialInstructions);
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese) Assert.Empty(BB.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var BB = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", BB.ToString());
        }
    }
}