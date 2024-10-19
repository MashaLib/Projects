
namespace LearnLab.NumberOperations
{
    public class LogicOperations
    {
       
        public static string CheckIfSumIsPerfectSquare(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        public static string CheckIfSumIsEvenOrOdd(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        public static string CalculateLCM(int firstNumber, int secondNumber)
        {
            int gcd = int.Parse(CalculateGCD(firstNumber, secondNumber));
            int lcm = (Math.Abs(firstNumber * secondNumber) / gcd);
            return lcm.ToString();
        }

        public static  string CalculateGCD(int firstNumber, int secondNumber)
        {
            //euclidian algorithm
            while (secondNumber != 0)
            {
                int temp = secondNumber;
                secondNumber = firstNumber % secondNumber;
                firstNumber = temp;
            }
            return firstNumber.ToString();
        }

        public static string CalculatePercentageRatioOfSum(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        public static string CompareNumbers(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }
    }
}
