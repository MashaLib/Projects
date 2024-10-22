using LearnLab.NumberOperations;

namespace LearnLab.UnitTests
{
    [TestClass]
    public class MathOperationsTests
    {
        [TestMethod]
        public void AddNumbers_ShouldReturnCorrectSumAsString_BasicPositiveNumbers()
        {
            // Arrange
            int firstNumber = 5;
            int secondNumber = 3;
            string expected = "8";

            // Act
            string result = MathOperations.CalculateAddition(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddNumbers_ShouldReturnZeroForAddingZeros()
        {
            // Arrange
            int firstNumber = 0;
            int secondNumber = 0;
            string expected = "0";

            // Act
            string result = MathOperations.CalculateAddition(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddNumbers_ShouldReturnCorrectSumForNegativeNumbers()
        {
            // Arrange
            int firstNumber = -5;
            int secondNumber = -3;
            string expected = "-8";

            // Act
            string result = MathOperations.CalculateAddition(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddNumbers_ShouldHandlePositiveAndNegativeNumbers()
        {
            // Arrange
            int firstNumber = 5;
            int secondNumber = -3;
            string expected = "2";

            // Act
            string result = MathOperations.CalculateAddition(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateSubtraction_ReturnsCorrectResultAsString_ForPositiveNumbers()
        {
            // Arrange
            int firstNumber = 10;
            int secondNumber = 3;
            string expected = "7";

            // Act
            string result = MathOperations.CalculateSubtraction(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateSubtraction_ReturnsCorrectResultAsString_ForNegativeNumbers()
        {
            // Arrange
            int firstNumber = -10;
            int secondNumber = -3;
            string expected = "-7";

            // Act
            string result = MathOperations.CalculateSubtraction(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateSubtraction_ReturnsCorrectResultAsString_ForSubtractionZeros()
        {
            // Arrange
            int firstNumber = 0;
            int secondNumber = 0;
            string expected = "0";

            // Act
            string result = MathOperations.CalculateSubtraction(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateSubtraction_ReturnsCorrectResultAsString_ForPositiveAndNegativeNumbers()
        {
            // Arrange
            int firstNumber = 5;
            int secondNumber = -7;
            string expected = "12";

            // Act
            string result = MathOperations.CalculateSubtraction(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }


    }
}
