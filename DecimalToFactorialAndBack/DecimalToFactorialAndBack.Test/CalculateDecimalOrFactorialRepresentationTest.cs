using DecimalToFactorialAndBack.App;
using Xunit;

namespace DecimalToFactorialAndBack.Test
{
    public class CalculateDecimalOrFactorialRepresentationTest
    {
        [Fact]
        public void DecimalNumberToFactorialRepresentation1_Successful()
        {
            //Arrange
            ICalculateDecimal calculateDeciman =
                new CalculateDecimal();
            var expected = "341010";
            long value = 463;

            //Act
            var actual = calculateDeciman.DecimalToFactorialString(value);

            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void DecimalNumberToFactorialRepresentation2_Successful()
        {
            //Arrange
            ICalculateDecimal calculateDecimal =
                new CalculateDecimal();
            var expected = "A0000000000";
            long value = 36288000;

            //Act
            var actual = calculateDecimal.DecimalToFactorialString(value);

            //Assert
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void DecimalNumberToFactorialRepresentation3_Successful()
        {
            //Arrange
            ICalculateDecimal calculateDecimal =
                new CalculateDecimal();
            var expected = "311E55B5544150121110";
            long value = 371993326789901217;

            //Act
            var actual = calculateDecimal.DecimalToFactorialString(value);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FactorialRepresentationToDecimalNumbe1r_Successful()
        {
            //Arrange
            ICalculateFactorialRepresentation calculateFactorialRepresentation =
                new CalculateFactorialRepresentation();
            var value = "341010";
            var expected = 463;

            //Act
            var actual = calculateFactorialRepresentation.FactorialStringToDecimal(value);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FactorialRepresentationToDecimalNumber2_Successful()
        {
            //Arrange
            ICalculateFactorialRepresentation calculateFactorialRepresentation =
                new CalculateFactorialRepresentation();
            var value = "A0000000000";
            var expected = 36288000;

            //Act
            var actual = calculateFactorialRepresentation.FactorialStringToDecimal(value);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FactorialRepresentationToDecimalNumber3_Successful()
        {
            //Arrange
            ICalculateFactorialRepresentation calculateFactorialRepresentation =
                new CalculateFactorialRepresentation();
            var value = "311E55B5544150121110";
            var expected = 371993326789901217;

            //Act
            var actual = calculateFactorialRepresentation.FactorialStringToDecimal(value);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
