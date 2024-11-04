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
    }
}