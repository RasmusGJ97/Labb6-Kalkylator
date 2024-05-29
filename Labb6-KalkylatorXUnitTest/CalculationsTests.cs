using Labb5_Kalkylator;

namespace Labb6_KalkylatorXUnitTest
{
    public class CalculationsTests
    {
        [Theory]
        [InlineData(3, 3, 6)]
        [InlineData(4, 2, 6)]
        [InlineData(2, 2, 4)]
        public void CalculationsAddition_ShouldAddTwoNumbersTogether(int x, int y, int actual)
        {
            //Arrange
            var calculations = new Calculations();

            //Act
            var result = calculations.Addition(x, y);

            //Assert
            Assert.Equal(actual, result);
        }

        [Theory]
        [InlineData(3, 3, 0)]
        [InlineData(4, 2, 2)]
        [InlineData(6, 2, 4)]
        public void CalculationsSubtraction_ShouldSubtractOneNumberFromAnother(int x, int y, int actual)
        {
            //Arrange
            var calculations = new Calculations();

            //Act
            var result = calculations.Subtraktion(x, y);

            //Assert
            Assert.Equal(actual, result);
        }

        [Theory]
        [InlineData(3, 3, 1)]
        [InlineData(4, 2, 2)]
        [InlineData(2, 2, 1)]
        public void CalculationsDivision_ShouldDivideOneNumberWithAnother(int x, int y, int actual)
        {
            //Arrange
            var calculations = new Calculations();

            //Act
            var result = calculations.Division(x, y);

            //Assert
            Assert.Equal(actual, result);
        }

        [Theory]
        [InlineData (1, 3, 3)]
        [InlineData (2, 3, 6)]
        [InlineData (3, 3, 9)]
        public void CalculationsMultiplikation_ShouldMultiplyTwoNumbersTogether(int x, int y, int actual)
        {
            //Arrange
            var calculations = new Calculations();           

            //Act
            var result = calculations.Multiplikation(x, y);

            //Assert
            Assert.Equal(actual, result);
        }

        [Fact]
        public void CalculationsAddCalculation_ShouldAddACalculationToList_WhenCalculationAreDone()
        {
            //Arrange
            var calculations = new Calculations();
            var calcHistory = new List<Calculations>();
            var result = calculations.Addition(1, 4);

            //Act
            Calculations addCalc = calculations.AddCalculation(1, 4, "+", result);
            calcHistory.Add(addCalc);

            //Assert
            Assert.Single(calcHistory);

        }
    }
}