using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Theory]
        [InlineData ("Drink")]
        [InlineData("Name")]
        [InlineData("Price")]        
        [InlineData("Calories")]
        [InlineData("SpecialInstructions")]
        [InlineData("Instructions")]
        public void ChangingDrinkInvokesCorrectPropertyChangeEvents(string property)
        {
            var C = new Combo(new AretinoAppleJuice(), new BriarheartBurger(), new FriedMiraak());
            Assert.PropertyChanged(C, property, () =>
            {
                C.Drink = new MarkarthMilk();
            });
        }

        [Theory]
        [InlineData("Entree")]
        [InlineData("Name")]
        [InlineData("Price")]
        [InlineData("Calories")]
        [InlineData("SpecialInstructions")]
        [InlineData("Instructions")]
        public void ChangingEntreeInvokesCorrectPropertyChangeEvents(string property)
        {
            var C = new Combo(new AretinoAppleJuice(), new BriarheartBurger(), new FriedMiraak());
            Assert.PropertyChanged(C, property, () =>
            {
                C.Entree = new ThalmorTriple();
            });
        }

        [Theory]
        [InlineData("Side")]
        [InlineData("Name")]
        [InlineData("Price")]
        [InlineData("Calories")]
        [InlineData("SpecialInstructions")]
        [InlineData("Instructions")]
        public void ChangingSideInvokesCorrectPropertyChangeEvents(string property)
        {
            var C = new Combo(new AretinoAppleJuice(), new BriarheartBurger(), new FriedMiraak());
            Assert.PropertyChanged(C, property, () =>
            {
                C.Side = new MadOtarGrits();
            });
        }

        [Fact]
        public void ChangingSubItemPriceInvokesCorrectPropertyChangedEvents()
        {
            var d = new AretinoAppleJuice();
            var e = new BriarheartBurger();
            var s = new FriedMiraak();
            var C = new Combo(d, e, s);
            Assert.PropertyChanged(C, "Price", () =>
            {
                s.Size = Data.Enums.Size.Medium;
            });
        }

        [Fact]
        public void ChangingSubItemCaloriesInvokesCorrectPropertyChangedEvents()
        {
            var d = new AretinoAppleJuice();
            var e = new BriarheartBurger();
            var s = new FriedMiraak();
            var C = new Combo(d, e, s);
            Assert.PropertyChanged(C, "Calories", () =>
            {
                s.Size = Data.Enums.Size.Medium;
            });
        }

        [Fact]
        public void ChangingSubItemSpecialInstructionsInvokesCorrectPropertyChangedEvents()
        {
            var d = new AretinoAppleJuice();
            var e = new BriarheartBurger();
            var s = new FriedMiraak();
            var C = new Combo(d, e, s);
            Assert.PropertyChanged(C, "Instructions", () =>
            {
                e.Bun = false;
            });
        }

        [Fact]
        public void PriceIsSumOfPricesOfItemsInComboMinusOne()
        {
            var C = new Combo(new AretinoAppleJuice(), new BriarheartBurger(), new FriedMiraak());
            Assert.Equal(8.72 - 1, C.Price);
        }

        [Fact]
        public void CaloriesIsSumOfCaloriesOfItemsInCombo()
        {
            var C = new Combo(new AretinoAppleJuice(), new BriarheartBurger(), new FriedMiraak());
            Assert.Equal((uint)938, C.Calories);
        }

        [Fact]
        public void ShouldReturnCombinedSpecialInstructions()
        {
            var d = new AretinoAppleJuice() { Ice = true};
            var e = new BriarheartBurger() { Bun = false };
            var s = new FriedMiraak();
            var C = new Combo(d, e, s);
            Assert.Contains("Small Aretino Apple Juice", C.SpecialInstructions);
            Assert.Contains("Briarheart Burger", C.SpecialInstructions);
            Assert.Contains("Small Fried Miraak", C.SpecialInstructions);
            Assert.Contains("Add ice", C.SpecialInstructions);
            Assert.Contains("Hold bun", C.SpecialInstructions);
            
        }
    }
}
