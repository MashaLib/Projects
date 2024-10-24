using LearnLab.NumberOperations;


namespace LearnLab.UnitTests
{
    [TestClass]
    public class DigitOperationTests
    {
        [TestMethod]        
        public void CalculateSumOfDigits_ReturnsStringOfSumOfDigits_ForTwoPositiveNumbers()
        {
            // Arrange
            int firstNumber = 123;
            int secondNumber = 4;
            string expected = "10";
            
            // Act
            string result = DigitOperations.CalculateSumOfDigits(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateSumOfDigits_ReturnsStringOfSumOfDigits_ForTwoNegativeNumbers()
        {
            // Arrange
            int firstNumber = -78;
            int secondNumber = -89;
            string expected = "2";

            // Act
            string result = DigitOperations.CalculateSumOfDigits(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}