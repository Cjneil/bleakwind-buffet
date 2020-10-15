
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class SideTests
    {
        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedSize()
        {
            Side db = new DragonbornWaffleFries();
            Assert.PropertyChanged(db as Side, "Size", () => {
                db.Size = Size.Medium;
            });
        }
        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedPrice()
        {
            Side db = new DragonbornWaffleFries();
            Assert.PropertyChanged(db as Side, "Price", () => {
                db.Size = Size.Medium;
            });
        }

        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedCalories()
        {
            Side db = new DragonbornWaffleFries();
            Assert.PropertyChanged(db as Side, "Calories", () => {
                db.Size = Size.Medium;
            });
        }

        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedToString()
        {
            Side db = new DragonbornWaffleFries();
            Assert.PropertyChanged(db as Side, "ToString", () => {
                db.Size = Size.Medium;
            });
        }

        [Fact]
        public void SizeChangeShouldTriggerPropertyChangedName()
        {
            Side db = new DragonbornWaffleFries();
            Assert.PropertyChanged(db as Side, "ToString", () => {
                db.Size = Size.Medium;
            });
        }
    }
}
