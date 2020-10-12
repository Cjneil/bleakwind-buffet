/*
 * Author: Zachery Brunner
 * Modified by: Connor Neil
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            Assert.IsAssignableFrom<Entree>(new ThugsTBone());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            Assert.IsAssignableFrom<IOrderItem>(new ThugsTBone());
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new BriarheartBurger());
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var TH = new ThugsTBone();
            Assert.Equal(6.44, TH.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var TH = new ThugsTBone();
            Assert.Equal(982u, TH.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var TH = new ThugsTBone();
            Assert.Empty(TH.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var TH = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", TH.ToString());
        }
    }
}