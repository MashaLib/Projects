using LearnLab.NumberOperations;    
namespace LearnLab.UnitTests
{
    [TestClass]
    public class LogicOperationsTests
    {
        [TestMethod]
        public void MyTestMethod()
        {

        }
        [TestMethod]
        public void CallculateLCM_ValidInput_ReturnsCorrectLCM()
        {
            //Arrange
            int firstNumber = 12;
            int secondNumber = 15;
            string expectedLCM = "60";
            //Act 
            string actualLCM = LogicOperations.CalculateLCM(firstNumber, secondNumber);
            //Assert 
            Assert.AreEqual(expectedLCM, actualLCM);
        }
        [TestMethod]
        public void CalculateGCD_ValidInput_ReturnsCorrectGCD()
        {
            //Arrange 
            int firstNumber = 12;
            int secondNumber = 15;
            string expectedGCD = "3";
            //Act
            string actualGCD = LogicOperations.CalculateGCD(firstNumber,secondNumber);
            //Assert 
            Assert.AreEqual (expectedGCD, actualGCD);
        }
        [TestMethod]    
        public void CalculateLCM_OneNumberZero_ReturnsZero()
        {
            //Arrange
            int firstNumber = 0;
            int secondNumber = 15;
            string expectedLCM = "0";
            //Act 
            string actualLCM = LogicOperations.CalculateLCM(firstNumber, secondNumber);
            //Assert
            Assert.AreEqual(expectedLCM, actualLCM);
        }
        [TestMethod]
        public void CalculateGCD_OneNumberZero_ReturnsOtherNumber()
        {
            //Arrange
            int firstNumber = 0;
            int secondNumber = 15;
            string expectedGCD = "15";
            //Act
            string actualGCD = LogicOperations.CalculateGCD (firstNumber, secondNumber);
            //Assert
            Assert.AreEqual(expectedGCD, actualGCD);
        }
        [TestMethod]
        public void CalculateLCM_NegativeNumbers_ReturnsPositiveLCM()
        {
            //Arrange
            int firstNumber = -12;
            int secondNumber = -15;
            string expectedLCM = "60";
            //Act 
            string actualLCM = LogicOperations.CalculateLCM(firstNumber, secondNumber);
            //Assert 
            Assert.AreEqual(expectedLCM, actualLCM);
        }
        [TestMethod]
        public void CalculateGCD_NegativeNumbers_ReturnsPositiveGCD()
        {
            //Arrange
            int firstNumber = -12;
            int secondNumber = -15;
            string expectedGCD = "3";
            //Act 
            string actualGCD = LogicOperations.CalculateLCM(firstNumber, secondNumber);
            //Assert 
            Assert.AreEqual(expectedGCD, actualGCD);
        }
        [TestMethod]
        public void CalculateLCM_LargeNumbers_ReturnsCorrectLCM()
        {
            //Arrange
            int firstNumber = 123456;
            int secondNumber = 789012;
            string expectedLCM = "8117355456";
            //Act 
            string actualLCM = LogicOperations.CalculateLCM(firstNumber, secondNumber);
            //Assert 
            Assert.AreEqual(expectedLCM, actualLCM);
        }
        [TestMethod]
        public void CalculateGCD_LargeNumbers_ReturnsCorrectGCD()
        {
            //Arrange
            int firstNumber = 123456;
            int secondNumber = 789012;
            string expectedGCD = "12";
            //Act 
            string actualGCD = LogicOperations.CalculateLCM(firstNumber, secondNumber);
            //Assert 
            Assert.AreEqual(expectedGCD, actualGCD);
        }
    }
}