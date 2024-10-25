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
            int firstNumber = -7;
            int secondNumber = -1;
            string expected = "8";

            // Act
            string result = DigitOperations.CalculateSumOfDigits(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateSumOfDigits_ReturnsStringOfSumOfDigits_ForZerosNumbers()
        {
            // Arrange
            int firstNumber = 0;
            int secondNumber = 0;
            string expected = "0";

            // Act
            string result = DigitOperations.CalculateSumOfDigits(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SplitNumberIntoIntArray_ReturnIntArray_ForPositveNumber() 
        {
            // Arrange
            int number = 123;
            int[] expected = { 1, 2, 3 };

            // Act
            int[] result = DigitOperations.SplitNumberIntoIntArray(number);

            // Assert
            CollectionAssert.AreEqual(expected, result);    
            CollectionAssert.AreEquivalent(expected, result);
        }

        [TestMethod]
        public void SplitNumberIntoIntArray_ReturnPositiveIntsArray_ForNegativeNumber()
        {
            // Arrange
            int number = -123;
            int[] expected = { 1, 2, 3 };

            // Act
            int[] resutl = DigitOperations.SplitNumberIntoIntArray(number);

            // Assert
            CollectionAssert.AreEqual(expected, resutl);
            CollectionAssert.AreEquivalent(expected, resutl);
        }
    }
}