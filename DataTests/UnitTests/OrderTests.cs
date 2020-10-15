using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        /// <summary>
        /// AA SHOULD force it to run first so Number is in fact in its initial state 
        /// but realistically it never runs first anyway soooooo just run this separately or it'll always fail
        /// </summary>
        [Fact]
        public void AANumberShouldStartAtOne()
        {
            var O = new Order();
            Assert.Equal(1, O.Number);
        }

        [Fact]
        public void NumberShouldIncreaseOneForEachOrderMade()
        {
            var O = new Order();
            var O2 = new Order();
            Assert.Equal(O.Number + 1, O2.Number);
        }

        [Fact]
        public void SalesTaxRateShouldBePointTwelveDefault()
        {
            var O = new Order();
            Assert.Equal(.12, O.SalesTaxRate);
        }
        
        [Fact]
        public void ShouldBeAbleToSetSalesTaxRate()
        {
            var O = new Order();
            Assert.True(O.SalesTaxRate == .12);
            O.SalesTaxRate = .13;
            Assert.True(O.SalesTaxRate == .13);
        }

        [Fact]
        public void SubtotalShouldBeZeroDefault()
        {
            var O = new Order();
            Assert.Equal(0, O.Subtotal);
        }

        [Fact]
        public void SubtotalShouldAddAllItemsPrices()
        {
            var O = new Order();
            AretinoAppleJuice d = new AretinoAppleJuice();
            BriarheartBurger b = new BriarheartBurger();
            VokunSalad v = new VokunSalad();
            var theoreticalPrice = d.Price + b.Price + v.Price;
            O.Add(d);
            O.Add(b);
            O.Add(v);
            Assert.Equal(theoreticalPrice, O.Subtotal);
        }

        [Fact]
        public void TaxShouldBeSalesTaxRateTimesSubtotal()
        {
            var O = new Order();
            AretinoAppleJuice d = new AretinoAppleJuice();
            BriarheartBurger b = new BriarheartBurger();
            VokunSalad v = new VokunSalad();
            double theoreticalPrice = d.Price + b.Price + v.Price;
            double theoreticalTax = .12 * theoreticalPrice;
            O.Add(d);
            O.Add(b);
            O.Add(v);
            Assert.Equal(theoreticalTax, O.Tax);
        }

        [Fact]
        public void TotalShouldBeTaxPlusSubtotal()
        {
            var O = new Order();
            AretinoAppleJuice d = new AretinoAppleJuice();
            BriarheartBurger b = new BriarheartBurger();
            VokunSalad v = new VokunSalad();
            double theoreticalPrice = d.Price + b.Price + v.Price;
            double theoreticalTax = .12 * theoreticalPrice;
            double theoreticalTotal = theoreticalPrice + theoreticalTax;
            O.Add(d);
            O.Add(b);
            O.Add(v);
            Assert.Equal(theoreticalTotal, O.Total);
        }

        [Fact]
        public void CaloriesShouldBeSumOfCalories()
        {
            var O = new Order();
            AretinoAppleJuice d = new AretinoAppleJuice();
            BriarheartBurger b = new BriarheartBurger();
            VokunSalad v = new VokunSalad();
            O.Add(d);
            O.Add(b);
            O.Add(v);
            Assert.Equal((uint)828, O.Calories);
        }

        [Fact]
        public void ChangingPriceOfIOrderItemInOrderShouldTriggerPropertyChangedSubtotal()
        {
            var O = new Order();
            AretinoAppleJuice d = new AretinoAppleJuice();
            O.Add(d);
            Assert.PropertyChanged(O, "Subtotal", () =>
            {
                d.Size = Size.Medium;
            });



        }

        [Fact]
        public void ChangingPriceOfIOrderItemInOrderShouldTriggerPropertyChangedTax()
        {
            var O = new Order();
            AretinoAppleJuice d = new AretinoAppleJuice();
            O.Add(d);
            Assert.PropertyChanged(O, "Tax", () =>
            {
                d.Size = Size.Medium;
            });


        }
        [Fact]
        public void ChangingPriceOfIOrderItemInOrderShouldTriggerPropertyChangedTotal()
        {
            var O = new Order();
            AretinoAppleJuice d = new AretinoAppleJuice();
            O.Add(d);
            Assert.PropertyChanged(O, "Total", () =>
            {
                d.Size = Size.Medium;
            });
        }

        [Fact]
        public void ChangingPriceOfIOrderItemInOrderShouldTriggerPropertyChangedCalories()
        {
            var O = new Order();
            AretinoAppleJuice d = new AretinoAppleJuice();
            O.Add(d);
            Assert.PropertyChanged(O, "Calories", () =>
            {
                d.Size = Size.Medium;
            });
        }

        [Theory]
        [InlineData ("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("Calories")]
        public void AddingAnIOrderItemShouldTriggerCorrectPropertyChangedEvents(string property)
        {
            var O = new Order();
            AretinoAppleJuice d = new AretinoAppleJuice();
            Assert.PropertyChanged(O, property, () =>
            {
                O.Add(d);
            });
        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("Calories")]
        public void RemovingAnIOrderItemShouldTriggerCorrectPropertyChangedEvents(string property)
        {
            var O = new Order();
            AretinoAppleJuice d = new AretinoAppleJuice();
            O.Add(d);
            Assert.PropertyChanged(O, property, () =>
            {
                O.Remove(d);
            });
        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Tax")]
        [InlineData("Total")]
        [InlineData("Calories")]
        public void ClearingOrderShouldTriggerCorrectPropertyChangedEvents(string property)
        {
            var O = new Order();
            AretinoAppleJuice d = new AretinoAppleJuice();
            Assert.PropertyChanged(O, property, () =>
            {
                O.ClearOrder();
            });
        }


    }
}
