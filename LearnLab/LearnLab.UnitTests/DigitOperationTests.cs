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
}
    