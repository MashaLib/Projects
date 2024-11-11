using LearnLab.NumberOperations;

namespace LearnLab.UnitTests
{
    [TestClass]
    public class MathOperationsTests
    {
        [TestMethod]
        public void AddNumbers_ShouldReturnCorrectSumAsString_BasicPositiveNumbers()
        {
            // Arrange
            int firstNumber = 5;
            int secondNumber = 3;
            string expected = "8";

            // Act
            string result = MathOperations.CalculateAddition(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddNumbers_ShouldReturnZeroForAddingZeros()
        {
            // Arrange
            int firstNumber = 0;
            int secondNumber = 0;
            string expected = "0";

            // Act
            string result = MathOperations.CalculateAddition(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddNumbers_ShouldReturnCorrectSumForNegativeNumbers()
        {
            // Arrange
            int firstNumber = -5;
            int secondNumber = -3;
            string expected = "-8";

            // Act
            string result = MathOperations.CalculateAddition(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AddNumbers_ShouldHandlePositiveAndNegativeNumbers()
        {
            // Arrange
            int firstNumber = 5;
            int secondNumber = -3;
            string expected = "2";

            // Act
            string result = MathOperations.CalculateAddition(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CheckIfNumbersAreFibonacci_BothFibonacciNumbers_ReturnsYesBoth()
        {
            //Arrange
            int firstNumber = 8; //Fibonacci number
            int secondNumber = 13; //Fibonacci number

            //Act
            string result = MathOperations.CheckIfNumbersAreFibonacci(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual("yes, both numbers", result);

        }

        [TestMethod]
        public void CheckIfNumbersAreFibonacci_OnlyFirstNumberIsFibonacci_ReturnsYesFirstNumber()
        {
            //Arrange
            int firstNumber = 5;    //Fibonacci Number
            int secondNumber = 4;   //Not a Fibonacci Number

            //Act
            string result = MathOperations.CheckIfNumbersAreFibonacci(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual("yes, first number", result);

        }

        [TestMethod]

        public void CheckIfNumbersAreFibonacci_OnlySecondNumberIsFibonacci_ReturnsYesSecondNumber()
        {

            //Arrange
            int firstNumber = 4;      //Not a Fibonacci number
            int secondNumber = 5;     //Fibonacci number

            //Act

            string result = MathOperations.CheckIfNumbersAreFibonacci(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual("yes, second number", result);
        }

        [TestMethod]


        public void CheckIfNumbersAreFibonacci_NeitherNumberIsFibonacci_ReturnsNo()
        {
            //Arrange

            int firstNumber = 4;    //Not a Fibonacci number
            int secondNumber = 6;    //Not a Fibonacci number

            //Act

            string result = MathOperations.CheckIfNumbersAreFibonacci(firstNumber, secondNumber);


            //Assert

            Assert.AreEqual("no", result);

        }

        [TestMethod]

        public void CheckIfNumbersAreFibonacci_NegativeNumbers_ReturnsNo()
        {

            //Arrange

            int firstNumber = -5;        //Negative number

            int secondNumber = -8;       //Negative number

            //Act
            string result = MathOperations.CheckIfNumbersAreFibonacci(firstNumber, secondNumber);

            //Assert

            Assert.AreEqual("no", result);


        }


        [TestMethod]

        public void CheckIfNumbersAreFibonacci_ZeroAsFibonacci_ReturnsYesFirstNumber()
        {
            //Arrange

            int firstNumber = 0;      // Fibonacci number
            int secondNumber = 4;     //Not a Fibonacci number

            //Act 
            string result = MathOperations.CheckIfNumbersAreFibonacci(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual("yes, first number", result);

        }

    }



}