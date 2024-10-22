using LearnLab.NumberOperations;


namespace LearnLab.UnitTests
{
    [TestClass]
    public class DigitOperationTests
    {
        [TestMethod]
        public void FindCommonDigits_ReturnsCommonDigitsOfTwoNumbersAsString()
        {
            // Arrange
            int firstNumber = 1223;
            int secondNumber = 4232;
            string expected = "2, 3";

            // Act
            string result = DigitOperations.FindCommonDigits(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}