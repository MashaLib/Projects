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
    }
}