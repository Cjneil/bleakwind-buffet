/*
 * Author: Zachery Brunner
 * Modified by: Connor Neil
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            Assert.IsAssignableFrom<Entree>(new ThalmorTriple());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            Assert.IsAssignableFrom<IOrderItem>(new ThalmorTriple());
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new ThalmorTriple());
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            var TT = new ThalmorTriple();
            TT.Bun = true;
            Assert.True(TT.Bun);
            TT.Bun = false;
            Assert.False(TT.Bun);
        }

        [Fact]
        public void BunChangeShouldTriggerPropertyChangedBunAndSpecialInstructions()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Bun", () => {
                TT.Bun = false;
            });
            Assert.PropertyChanged(TT, "SpecialInstructions", () => {
                TT.Bun = true;
            });
            Assert.PropertyChanged(TT, "Instructions", () => {
                TT.Bun = true;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            var TT = new ThalmorTriple();
            TT.Ketchup = true;
            Assert.True(TT.Ketchup);
            TT.Ketchup = false;
            Assert.False(TT.Ketchup);
        }

        [Fact]
        public void KetchupChangeShouldTriggerPropertyChangedKetchupAndSpecialInstructions()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Ketchup", () => {
                TT.Ketchup = false;
            });
            Assert.PropertyChanged(TT, "SpecialInstructions", () => {
                TT.Ketchup = true;
            });
            Assert.PropertyChanged(TT, "Instructions", () => {
                TT.Ketchup = true;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            var TT = new ThalmorTriple();
            TT.Mustard = true;
            Assert.True(TT.Mustard);
            TT.Mustard = false;
            Assert.False(TT.Mustard);
        }

        [Fact]
        public void MustardChangeShouldTriggerPropertyChangedMustardAndSpecialInstructions()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Mustard", () => {
                TT.Mustard = false;
            });
            Assert.PropertyChanged(TT, "SpecialInstructions", () => {
                TT.Mustard = true;
            });
            Assert.PropertyChanged(TT, "instructions", () => {
                TT.Mustard = true;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            var TT = new ThalmorTriple();
            TT.Pickle = true;
            Assert.True(TT.Pickle);
            TT.Pickle = false;
            Assert.False(TT.Pickle);
        }

        [Fact]
        public void PickleChangeShouldTriggerPropertyChangedPickleAndSpecialInstructions()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Pickle", () => {
                TT.Pickle = false;
            });
            Assert.PropertyChanged(TT, "SpecialInstructions", () => {
                TT.Pickle = true;
            });
            Assert.PropertyChanged(TT, "Instructions", () => {
                TT.Pickle = true;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            var TT = new ThalmorTriple();
            TT.Cheese = true;
            Assert.True(TT.Cheese);
            TT.Cheese = false;
            Assert.False(TT.Cheese);
        }

        [Fact]
        public void CheeseChangeShouldTriggerPropertyChangedCheeseAndSpecialInstructions()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Cheese", () => {
                TT.Cheese = false;
            });
            Assert.PropertyChanged(TT, "SpecialInstructions", () => {
                TT.Cheese = true;
            });
            Assert.PropertyChanged(TT, "Instructions", () => {
                TT.Cheese = true;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var TT = new ThalmorTriple();
            TT.Tomato = true;
            Assert.True(TT.Tomato);
            TT.Tomato = false;
            Assert.False(TT.Tomato);
        }

        [Fact]
        public void TomatoChangeShouldTriggerPropertyChangedTomatoAndSpecialInstructions()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Tomato", () => {
                TT.Tomato = false;
            });
            Assert.PropertyChanged(TT, "SpecialInstructions", () => {
                TT.Tomato = true;
            });
            Assert.PropertyChanged(TT, "Instructions", () => {
                TT.Tomato = true;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            var TT = new ThalmorTriple();
            TT.Lettuce = true;
            Assert.True(TT.Lettuce);
            TT.Lettuce = false;
            Assert.False(TT.Lettuce);
        }

        [Fact]
        public void LettuceChangeShouldTriggerPropertyChangedLettuceAndSpecialInstructions()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Lettuce", () => {
                TT.Lettuce = false;
            });
            Assert.PropertyChanged(TT, "SpecialInstructions", () => {
                TT.Lettuce = true;
            });
            Assert.PropertyChanged(TT, "Instructions", () => {
                TT.Lettuce = true;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            var TT = new ThalmorTriple();
            TT.Mayo = true;
            Assert.True(TT.Mayo);
            TT.Mayo = false;
            Assert.False(TT.Mayo);
        }

        [Fact]
        public void MayoChangeShouldTriggerPropertyChangedMayoAndSpecialInstructions()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Mayo", () => {
                TT.Mayo = false;
            });
            Assert.PropertyChanged(TT, "SpecialInstructions", () => {
                TT.Mayo = true;
            });
            Assert.PropertyChanged(TT, "Instructions", () => {
                TT.Mayo = true;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            var TT = new ThalmorTriple();
            TT.Bacon = true;
            Assert.True(TT.Bacon);
            TT.Bacon = false;
            Assert.False(TT.Bacon);
        }

        [Fact]
        public void BaconChangeShouldTriggerPropertyChangedBaconAndSpecialInstructions()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Bacon", () => {
                TT.Bacon = false;
            });
            Assert.PropertyChanged(TT, "SpecialInstructions", () => {
                TT.Bacon = true;
            });
            Assert.PropertyChanged(TT, "Instructions", () => {
                TT.Bacon = true;
            });
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            var TT = new ThalmorTriple();
            TT.Egg = true;
            Assert.True(TT.Egg);
            TT.Egg = false;
            Assert.False(TT.Egg);
        }

        [Fact]
        public void EggChangeShouldTriggerPropertyChangedEggAndSpecialInstructions()
        {
            var TT = new ThalmorTriple();
            Assert.PropertyChanged(TT, "Egg", () => {
                TT.Egg = false;
            });
            Assert.PropertyChanged(TT, "SpecialInstructions", () => {
                TT.Egg = true;
            });
            Assert.PropertyChanged(TT, "Instructions", () => {
                TT.Egg = true;
            });
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var TT = new ThalmorTriple();
            Assert.Equal(8.32, TT.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var TT = new ThalmorTriple();
            Assert.Equal(943u, TT.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            var TT = new ThalmorTriple()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo,
                Bacon = includeBacon,
                Egg = includeEgg
            };
            if (!includeBacon) Assert.Contains("Hold bacon", TT.SpecialInstructions);
            if (!includeBun) Assert.Contains("Hold bun", TT.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", TT.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", TT.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", TT.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", TT.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", TT.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", TT.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", TT.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", TT.SpecialInstructions);
            if (includeBacon && includeBun && includeCheese && includeEgg && includeKetchup && includeLettuce && includeMayo && includeMustard && includePickle && includeTomato) Assert.Empty(TT.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var TT = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", TT.ToString());
        }
    }
}