/*
 * Author: Zachery Brunner
 * Modified by: Connor Neil
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldIncludeBroccoliByDefault()
        {
            var GO = new GardenOrcOmelette();
            Assert.True(GO.Broccoli);
        }

        [Fact]
        public void ShouldIncludeMushroomsByDefault()
        {
            var GO = new GardenOrcOmelette();
            Assert.True(GO.Broccoli);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            var GO = new GardenOrcOmelette();
            Assert.True(GO.Tomato);
        }

        [Fact]
        public void ShouldIncludeCheddarByDefault()
        {
            var GO = new GardenOrcOmelette();
            Assert.True(GO.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            var GO = new GardenOrcOmelette();
            GO.Broccoli = true;
            Assert.True(GO.Broccoli);
            GO.Broccoli = false;
            Assert.False(GO.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            var GO = new GardenOrcOmelette();
            GO.Mushrooms = true;
            Assert.True(GO.Mushrooms);
            GO.Mushrooms = false;
            Assert.False(GO.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var GO = new GardenOrcOmelette();
            GO.Tomato = true;
            Assert.True(GO.Tomato);
            GO.Tomato = false;
            Assert.False(GO.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            var GO = new GardenOrcOmelette();
            GO.Cheddar = true;
            Assert.True(GO.Cheddar);
            GO.Cheddar = false;
            Assert.False(GO.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var GO = new GardenOrcOmelette();
            Assert.Equal(4.57, GO.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var GO = new GardenOrcOmelette();
            Assert.Equal(404u, GO.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            var GO = new GardenOrcOmelette()
            {
                Broccoli = includeBroccoli,
                Mushrooms = includeMushrooms,
                Tomato = includeTomato,
                Cheddar = includeCheddar
            };
            if (!includeBroccoli) Assert.Contains("Hold broccoli", GO.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", GO.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", GO.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato",GO.SpecialInstructions);
            if (includeBroccoli && includeCheddar && includeMushrooms && includeTomato) Assert.Empty(GO.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var GO = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", GO.ToString());
        }
    }
}