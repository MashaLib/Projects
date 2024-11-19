using LearnLab.NumberOperations;
namespace LearnLab.UnitTests
{
    [TestClass]
    public class CompareNumbersTests
    {
        [TestMethod]
        public void Test_FirstNumberLessThanSecond()
        {
            int firstNumber = 3;
            int secondNumber = 5;
            string expectedResult = "less";

            string result = LogicOperations.CompareNumbers(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FirstNumberGreaterThanSecond()
        {
            int firstNumber = 10;
            int secondNumber = 5;
            string expectedResult = "greater";

            string result = LogicOperations.CompareNumbers(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FirstNumberEqualToSecond()
        {
            int firstNumber = 7;
            int secondNumber = 7;
            string expectedResult = "equal";

            string result = LogicOperations.CompareNumbers(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FirstNumberNegativeSecondPositive()
        {
            int firstNumber = -3;
            int secondNumber = 5;
            string expectedResult = "less";

            string result = LogicOperations.CompareNumbers(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_FirstNumberPositiveSecondNegative()
        {
            int firstNumber = 5;
            int secondNumber = -3;
            string expectedResult = "greater";

            string result = LogicOperations.CompareNumbers(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_BothNumbersNegativeFirstLess()
        {
            int firstNumber = -10;
            int secondNumber = -5;
            string expectedResult = "less";

            string result = LogicOperations.CompareNumbers(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Test_BothNumbersNegativeFirstGreater()
        {
            int firstNumber = -5;
            int secondNumber = -10;
            string expectedResult = "greater";

            string result = LogicOperations.CompareNumbers(firstNumber, secondNumber);

            Assert.AreEqual(expectedResult, result);
        }
    }
}