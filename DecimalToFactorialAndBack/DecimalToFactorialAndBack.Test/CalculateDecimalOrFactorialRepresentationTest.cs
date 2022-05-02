using Xunit;

namespace DecimalToFactorialAndBack.Test
{
    public class CalculateDecimalOrFactorialRepresentationTest
    {
        [Fact]
        public void DecimalNumberToFactorialRepresentation_Successful()
        {
            //Arrange
            ICalculateDecimalOrFactorialRepresentation calculateDecimalOrFactorialRepresentation =
                new CalculateDecimalOrFactorialRepresentation();
            var expected = "341010";
            var value = 463;

            //Act
            var actual = calculateDecimalOrFactorialRepresentation.DecimalToFactorialString(value);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FactorialRepresentationToDecimalNumber_Successful()
        {
            //Arrange
            ICalculateDecimalOrFactorialRepresentation calculateDecimalOrFactorialRepresentation =
                new CalculateDecimalOrFactorialRepresentation();
            var value = "341010";
            var expected = 463;

            //Act
            var actual = calculateDecimalOrFactorialRepresentation.DecimalToFactorialString(value);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
