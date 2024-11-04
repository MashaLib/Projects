using LearnLab.NumberOperations;


namespace LearnLab.UnitTests
{
    [TestClass]
    public class DigitOperationTests
    {
        [TestMethod]
        public void CheckIfNumbersAreDigitAnagrams_ForSameNumbers()
        {
            // Arrange
            int firstNumber = 123;
            int secondNumber = 123;
            string expected = "YES";

            // Act
            string result = DigitOperations.CheckIfNumbersAreDigitAnagrams(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}