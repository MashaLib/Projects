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
    }
    [TestClass]
    public class CalculateMultiplicationTests
    {
        [TestMethod]
        public void Test_PositiveNumbers()
        {
            int firstNumber = 3;
            int secondNumber = 5;
            string expectedResult = "15";

            string result = MathOperations.CalculateMultiplication(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_NegativeAndPositiveNumber()
        {
            int firstNumber = -4;
            int secondNumber = 6;
            string expectedResult = "-24";

            string result = MathOperations.CalculateMultiplication(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_BothNegativeNumbers()
        {
            int firstNumber = -7;
            int secondNumber = -3;
            string expectedResult = "21";

            string result = MathOperations.CalculateMultiplication(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_MultiplicationWithZero()
        {
            int firstNumber = 0;
            int secondNumber = 10;
            string expectedResult = "0";

            string result = MathOperations.CalculateMultiplication(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_LargeNumbers()
        {
            int firstNumber = 10000;
            int secondNumber = 2000;
            string expectedResult = "20000000";

            string result = MathOperations.CalculateMultiplication(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_OneNumberIsOne()
        {
            int firstNumber = 1;
            int secondNumber = 1234;
            string expectedResult = "1234";

            string result = MathOperations.CalculateMultiplication(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }
    }
}