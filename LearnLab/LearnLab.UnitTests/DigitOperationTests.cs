using LearnLab.NumberOperations;



namespace LearnLab.UnitTests
{
    [TestClass]
    public class NumbersAreMirror
    {
        [TestMethod]
        //naming: Method_Scenario_ExpectedOutcome
        public void CheckIfNumbersAreMirrors_MirrorNumbers_ReturnsYes()
        {
            //arrange
            int firstNumber = 123;
            int secondNumber = 321;
            //act
            string result = DigitOperations.CheckIfNumbersAreMirrors(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual("Yes", result);

        }
        [TestMethod]
        public void CheckIfNumbersAreMirrors_MirrorNumbers_ReturnsNo()
        {
            //Arrange
            int firstNumber = 123;
            int secondNumber = 123;

            //Act
            string result = DigitOperations.CheckIfNumbersAreMirrors(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual("No", result);
        }

        [TestMethod]

        public void CheckIfNumbersAreMirrors_MirrorNumbers_SingleDigitNumbers_ReturnYes()
        {
            //Arrange
            int firstNumber = 7;
            int secondNumber = 7;

            //Act
            string result = DigitOperations.CheckIfNumbersAreMirrors(firstNumber, secondNumber);

            //Assert
            Assert.AreEqual("Yes", result);

        }
        [TestMethod]
        public void CheckIfNumbersAreMirrors_MirrorNumbers_MirrorWithLeadingZeros_ReturnYes()
        {
            //Arrange
            int firstNUmber = 120;
            int secondNumner = 21; //21should match the reverse of 120 without leading zeros

            //Act
            string result = DigitOperations.CheckIfNumbersAreMirrors(firstNUmber, secondNumner);
        }


        [TestMethod]

        public void CheckIfNumbersAreMirrors_NegativeNumbers_ReturnsNo()

        {
            //Arrange
            int firstNumber = 123;
            int secondNumber = 321;

            //Act
            string result = DigitOperations.CheckIfNumbersAreMirrors(firstNumber, secondNumber);

            //Assert 
            Assert.AreEqual("No", result);

        }

        [TestMethod]

          public void CheckIfNumbersAreMirrors_LargeMirrorNumbers_ReturnYes()
        {

            //Arrange
            int firstNumber = 123456789;
            int secondNumber = 987654321;

            //Act

            string result = DigitOperations.CheckIfNumbersAreDigitAnagrams(firstNumber, secondNumber);

            //Assert

            Assert.AreEqual("Yes", result);
        }




    }
}