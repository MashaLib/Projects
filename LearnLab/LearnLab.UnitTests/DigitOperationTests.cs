using LearnLab.NumberOperations;


namespace LearnLab.UnitTests
{
    [TestClass]
    public class PerformZigzagMergeTests
    {
        [TestMethod]
        public void Test_BothNumbersWithEqualLength()
        {
            int firstNumber = 1234;
            int secondNumber = 5678;
            string expectedResult = "15263748";

            string result = DigitOperations.PerformZigzagMerge(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FirstNumberShorterThanSecondNumber()
        {
            int firstNumber = 123;
            int secondNumber = 56789;
            string expectedResult = "15263789";

            string result = DigitOperations.PerformZigzagMerge(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_SecondNumberShorterThanFirstNumber()
        {
            int firstNumber = 12345;
            int secondNumber = 67;
            string expectedResult = "1627345";

            string result = DigitOperations.PerformZigzagMerge(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_OneNumberIsZero()
        {
            int firstNumber = 0;
            int secondNumber = 5678;
            string expectedResult = "05678";

            string result = DigitOperations.PerformZigzagMerge(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_BothNumbersAreZero()
        {
            int firstNumber = 0;
            int secondNumber = 0;
            string expectedResult = "00";

            string result = DigitOperations.PerformZigzagMerge(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FirstNumberHasSingleDigit()
        {
            int firstNumber = 9;
            int secondNumber = 1234;
            string expectedResult = "91234";

            string result = DigitOperations.PerformZigzagMerge(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_SecondNumberHasSingleDigit()
        {
            int firstNumber = 1234;
            int secondNumber = 5;
            string expectedResult = "15234";

            string result = DigitOperations.PerformZigzagMerge(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }
    }
    [TestClass]
    public class FindUniqueDigitsTests
    {
        [TestMethod]
        public void Test_NoUniqueDigits()
        {
            int firstNumber = 12345;
            int secondNumber = 54321;
            string expectedResult = "";

            string result = DigitOperations.FindUniqueDigits(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_UniqueDigitsInBothNumbers()
        {
            int firstNumber = 123;
            int secondNumber = 678;
            string expectedResult = "123678";

            string result = DigitOperations.FindUniqueDigits(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, new string(result.OrderBy(c => c).ToArray()));
        }

        [TestMethod]
        public void Test_WithDuplicateDigitsInNumbers()
        {
            int firstNumber = 112233;
            int secondNumber = 233445;
            string expectedResult = "145";

            string result = DigitOperations.FindUniqueDigits(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, new string(result.OrderBy(c => c).ToArray()));
        }

        [TestMethod]
        public void Test_OneNumberIsZero()
        {
            int firstNumber = 0;
            int secondNumber = 123;
            string expectedResult = "0123";

            string result = DigitOperations.FindUniqueDigits(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, new string(result.OrderBy(c => c).ToArray()));
        }

        [TestMethod]
        public void Test_BothNumbersAreZero()
        {
            int firstNumber = 0;
            int secondNumber = 0;
            string expectedResult = "";

            string result = DigitOperations.FindUniqueDigits(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }
    }
    [TestClass]
    public class CountDigitsTests
    {
        [TestMethod]
        public void Test_SingleDigitNumbers()
        {
            int firstNumber = 3;
            int secondNumber = 7;
            string expectedResult = "2";

            string result = DigitOperations.CountDigits(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_MultiDigitNumbers()
        {
            int firstNumber = 123;
            int secondNumber = 4567;
            string expectedResult = "7";

            string result = DigitOperations.CountDigits(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_OneNumberIsZero()
        {
            int firstNumber = 0;
            int secondNumber = 12345;
            string expectedResult = "6";

            string result = DigitOperations.CountDigits(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_BothNumbersAreZero()
        {
            int firstNumber = 0;
            int secondNumber = 0;
            string expectedResult = "2";

            string result = DigitOperations.CountDigits(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_LargeNumbers()
        {
            int firstNumber = 123456789;
            int secondNumber = 987654321;
            string expectedResult = "18";

            string result = DigitOperations.CountDigits(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }      
    }
}
    