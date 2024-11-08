using LearnLab.NumberOperations;


namespace LearnLab.UnitTests
{
    [TestClass]
    public class DigitOperationTests
    {
        [TestMethod]
        public void FindCommonDigits_ReturnsResultAsString_ForCommonDigits()
        {
            // Arrange
            int firstNumber = 12345;
            int secondNumber = 54321;
            string expected = "1, 2, 3, 4, 5";

            // Act
            string result = DigitOperations.FindCommonDigits(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindCommonDigits_ReturnsResultAsString_ForNoCommonDigits()
        {
            // Arrange
            int firstNumber = 123;
            int secondNumber = 456;
            string expected = "";

            // Act
            string result = DigitOperations.FindCommonDigits(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindCommonDigits_ReturnsResultAsString_ForSingleCommonDigit()
        {
            // Arrange
            int firstNumber = 123;
            int secondNumber = 356;
            string expected = "3";

            // Act
            string result = DigitOperations.FindCommonDigits(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindCommonDigits_ReturnsResultAsString_ForRepeatedDigitsInEachNumber()
        {
            // Arrange
            int firstNumber = 112233;
            int secondNumber = 233445;
            string expected = "2, 3";

            // Act
            string result = DigitOperations.FindCommonDigits(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindCommonDigits_ReturnsResultAsString_ForCommonDigitsInDifferentOrders()
        {
            // Arrange
            int firstNumber = 531;
            int secondNumber = 531;
            string expected = "5, 3, 1";

            // Act
            string result = DigitOperations.FindCommonDigits(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindCommonDigits_ReturnsResultAsString_ForNoDigitsZeroValues()
        {
            // Arrange
            int firstNumber = 0;
            int secondNumber = 0;
            string expected = "0";

            // Act
            string result = DigitOperations.FindCommonDigits(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindCommonDigits_ReturnsResultAsString_ForNegativeNumbers()
        {
            // Arrange
            int firstNumber = -123;
            int secondNumber = 345;
            string expected = "3";

            // Act
            string result = DigitOperations.FindCommonDigits(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FindCommonDigits_ReturnsResultAsString_ForOneNumberIsZero()
        {
            // Arrange
            int firstNumber = 0;
            int secondNumber = 123;
            string expected = "";

            // Act
            string result = DigitOperations.FindCommonDigits(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}