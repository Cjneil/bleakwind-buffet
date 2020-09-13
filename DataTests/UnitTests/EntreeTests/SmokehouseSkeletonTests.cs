/*
 * Author: Zachery Brunner
 * Modified by: Connor Neil
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            Assert.IsAssignableFrom<Entree>(new SmokehouseSkeleton());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            Assert.IsAssignableFrom<IOrderItem>(new SmokehouseSkeleton());
        }

        [Fact]
        public void ShouldIncludeSausageByDefault()
        {
            var SS = new SmokehouseSkeleton();
            Assert.True(SS.SausageLink);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            var SS = new SmokehouseSkeleton();
            Assert.True(SS.Egg);
        }

        [Fact]
        public void ShouldIncludeHashbrownsByDefault()
        {
            var SS = new SmokehouseSkeleton();
            Assert.True(SS.HashBrowns);
        }

        [Fact]
        public void ShouldIncludePancakeByDefault()
        {
            var SS = new SmokehouseSkeleton();
            Assert.True(SS.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            var SS = new SmokehouseSkeleton();
            SS.SausageLink = true;
            Assert.True(SS.SausageLink);
            SS.SausageLink = false;
            Assert.False(SS.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            var SS = new SmokehouseSkeleton();
            SS.Egg = true;
            Assert.True(SS.Egg);
            SS.Egg = false;
            Assert.False(SS.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            var SS = new SmokehouseSkeleton();
            SS.HashBrowns = true;
            Assert.True(SS.HashBrowns);
            SS.HashBrowns = false;
            Assert.False(SS.HashBrowns);

        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            var SS = new SmokehouseSkeleton();
            SS.Pancake = true;
            Assert.True(SS.Pancake);
            SS.Pancake = false;
            Assert.False(SS.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var SS = new SmokehouseSkeleton();
            Assert.Equal(5.62, SS.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var SS = new SmokehouseSkeleton();
            Assert.Equal(602u, SS.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            var SS = new SmokehouseSkeleton()
            {
                SausageLink = includeSausage,
                Egg = includeEgg,
                HashBrowns = includeHashbrowns,
                Pancake = includePancake
            };
            if (!includeEgg) Assert.Contains("Hold eggs", SS.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", SS.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancakes", SS.SpecialInstructions);
            if (!includeSausage) Assert.Contains("Hold sausage", SS.SpecialInstructions);
            if (includeEgg && includeHashbrowns && includePancake && includeSausage) Assert.Empty(SS.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var SS = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", SS.ToString());
        }
    }
}