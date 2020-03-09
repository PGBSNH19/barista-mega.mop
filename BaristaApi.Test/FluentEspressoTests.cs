using System;
using Xunit;

namespace BaristaApi.Test
{
    public class FluentEspressoTests
    {
        [Fact]
        public void ToBeverage_NothingAdded_Null()
        {
            // Arrange
            // Act
            var result = new FluentEspresso().ToBeverage();
            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void ToBeverage_AddEspresso_Espresso()
        {
            // Arrange
            // Act
            var result = new FluentEspresso().AddEspresso(25).ToBeverage();

            // Assert
            Assert.IsType<Espresso>(result);
        }

        [Fact]
        public void ToBeverage_AddEspressoAndMilk_Latte()
        {
            // Arrange
            // Act
            var result = new FluentEspresso().AddEspresso(10).AddMilk(15).ToBeverage();

            // Assert
            Assert.IsType<Latte>(result);
        }

        [Fact]
        public void ToBeverage_AddEspressoAndValidateSize_TrueCanFit()
        {
            // Arrange
            int sizeOfCup = 30; //ml
            // Act
            var result = new FluentEspresso().AddEspresso(25).CanItBeInCup(amountInCup => amountInCup < sizeOfCup);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ToBeverage_AddEspressoAndValidateSize_FalseCantFit()
        {
            // Arrange
            int sizeOfCup = 20; //ml
            // Act
            var result = new FluentEspresso().AddEspresso(25).CanItBeInCup(amountInCup => amountInCup < sizeOfCup);

            // Assert
            Assert.False(result);
        }
    }
}
