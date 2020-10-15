using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class BaseClassesTests
    {

        [Fact]
        public void DrinkInstructionsReturnsProperlyFormattedString()
        {
            Drink d = new AretinoAppleJuice() { Ice = true } ;
            Assert.Equal("- Add ice\n", d.Instructions);
        }

        [Fact]
        public void DrinkNameReturnsToStringAsAProperty()
        {
            Drink d = new AretinoAppleJuice();
            Assert.Equal("Small Aretino Apple Juice", d.Name);
        }

        [Fact]
        public void DrinkNotifyPropertyChangedInvokesCorrectPropertyChanged()
        {
            var d = new AretinoAppleJuice();
            Assert.PropertyChanged(d as Drink, "Calories", () =>
            {
                d.Size = Size.Medium;
            });

            Assert.PropertyChanged(d as Drink, "Instructions", () =>
            {
                d.Ice = true;
            });

            Assert.PropertyChanged(d as Drink, "Name", () =>
            {
                d.Size = Size.Large;
            });
        }

        [Fact]
        public void EntreeInstructionsReturnsProperlyFormattedString()
        {
            Entree b = new BriarheartBurger() { Bun = false };
            Assert.Equal("- Hold bun\n", b.Instructions);
        }

        [Fact]
        public void EntreeNameReturnsToStringAsAProperty()
        {
            Entree b = new BriarheartBurger();
            Assert.Equal("Briarheart Burger", b.Name);
        }

        [Fact]
        public void EntreeNotifyPropertyChangedInvokesCorrectPropertyChanged()
        {
            var b = new BriarheartBurger();
            Assert.PropertyChanged(b as Entree, "Instructions", () =>
            {
                b.Bun = false;
            });
        }

        [Fact]
        public void SideInstructionsReturnsProperlyFormattedString()
        {
            Side d = new DragonbornWaffleFries();
            Assert.Equal("", d.Instructions);
        }

        [Fact]
        public void SideNameReturnsToStringAsAProperty()
        {
            Side d = new DragonbornWaffleFries();
            Assert.Equal("Small Dragonborn Waffle Fries", d.Name);
        }

    }
}
