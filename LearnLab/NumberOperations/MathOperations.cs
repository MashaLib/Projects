
namespace LearnLab.NumberOperations
{
    public class MathOperations
    {
        
        public static string CalculateAddition(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result.ToString();
        }

        public static string CalculateAverage(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        public static string CalculateDivision(int firstNumber, int secondNumber)
        {
            if (secondNumber != 0)
            {
                int result = firstNumber / secondNumber;
                return result.ToString();
            }
            else
            {
                return "Division by zero is not allowed";
            }
        }

        public static string CalculateDivisionWithRemainder(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }
        
        public static string CalculateFactorialOfSum(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        public static string CalculateMultiplication(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        public static string CalculatePower(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        public static string CalculateSubtraction(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        public static string CheckIfNumbersAreFibonacci(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        public static string CheckIfSumIsPrime(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

    }
}
