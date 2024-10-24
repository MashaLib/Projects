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
    }
}