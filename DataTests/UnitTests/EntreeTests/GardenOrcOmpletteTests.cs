/*
 * Author: Zachery Brunner
 * Modified by: Connor Neil
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAnEntree()
        {
            Assert.IsAssignableFrom<Entree>(new GardenOrcOmelette());
        }

        [Fact]
        public void ShouldBeAssignableToIOrderItemInterface()
        {
            Assert.IsAssignableFrom<IOrderItem>(new GardenOrcOmelette());
        }

        [Fact]
        public void ShouldBeAssignableToINotifyPropertyChanged()
        {
            Assert.IsAssignableFrom<INotifyPropertyChanged>(new GardenOrcOmelette());
        }

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
        public void BroccoliChangeShouldTriggerPropertyChangedBroccooliAndSpecialInstructions()
        {
            var GO = new GardenOrcOmelette();
            Assert.PropertyChanged(GO, "Broccoli", () => {
                GO.Broccoli = false;
            });
            Assert.PropertyChanged(GO, "SpecialInstructions", () => {
                GO.Broccoli = true;
            });
            Assert.PropertyChanged(GO, "Instructions", () => {
                GO.Broccoli = true;
            });
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
        public void MushroomsChangeShouldTriggerPropertyChangedMushroomsAndSpecialInstructions()
        {
            var GO = new GardenOrcOmelette();
            Assert.PropertyChanged(GO, "Mushrooms", () => {
                GO.Mushrooms = false;
            });
            Assert.PropertyChanged(GO, "SpecialInstructions", () => {
                GO.Mushrooms = true;
            });
            Assert.PropertyChanged(GO, "Instructions", () => {
                GO.Mushrooms = true;
            });
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
        public void TomatoChangeShouldTriggerPropertyChangedTomatoAndSpecialInstructions()
        {
            var GO = new GardenOrcOmelette();
            Assert.PropertyChanged(GO, "Tomato", () => {
                GO.Tomato = false;
            });
            Assert.PropertyChanged(GO, "SpecialInstructions", () => {
                GO.Tomato = true;
            });
            Assert.PropertyChanged(GO, "Instructions", () => {
                GO.Tomato = true;
            });
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
        public void CheddarChangeShouldTriggerPropertyChangedCheddarAndSpecialInstructions()
        {
            var GO = new GardenOrcOmelette();
            Assert.PropertyChanged(GO, "Cheddar", () => {
                GO.Cheddar = false;
            });
            Assert.PropertyChanged(GO, "SpecialInstructions", () => {
                GO.Cheddar = true;
            });
            Assert.PropertyChanged(GO, "Instructions", () => {
                GO.Cheddar = true;
            });
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

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            var GO = new GardenOrcOmelette();
            Assert.Equal("Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.", GO.Description);
        }
    }
}