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
    public class CalculateDivisionTests
    {
        [TestMethod]
        public void Test_DivisionWithPositiveNumbers()
        {
            int firstNumber = 10;
            int secondNumber = 2;
            string expectedResult = "5";

            string result = MathOperations.CalculateDivision(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_DivisionWithNegativeAndPositiveNumber()
        {
            int firstNumber = -10;
            int secondNumber = 2;
            string expectedResult = "-5";

            string result = MathOperations.CalculateDivision(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_DivisionWithBothNegativeNumbers()
        {
            int firstNumber = -10;
            int secondNumber = -2;
            string expectedResult = "5";

            string result = MathOperations.CalculateDivision(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_DivisionResultingInDecimal()
        {
            int firstNumber = 7;
            int secondNumber = 2;
            string expectedResult = "3"; 

            string result = MathOperations.CalculateDivision(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_DivisionByZero()
        {
            int firstNumber = 10;
            int secondNumber = 0;
            string expectedResult = "Division by zero is not allowed";

            string result = MathOperations.CalculateDivision(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_ZeroDividedByNumber()
        {
            int firstNumber = 0;
            int secondNumber = 5;
            string expectedResult = "0";

            string result = MathOperations.CalculateDivision(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_DivisionWithOne()
        {
            int firstNumber = 10;
            int secondNumber = 1;
            string expectedResult = "10";

            string result = MathOperations.CalculateDivision(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }
    }
}