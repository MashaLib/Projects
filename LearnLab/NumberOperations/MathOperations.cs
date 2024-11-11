
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
            throw new NotImplementedException();
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
            bool IsFirstFibonacci = IsFibonacci(firstNumber);
            bool IsSecondFibonacci = IsFibonacci(secondNumber);

            if (IsFirstFibonacci && IsSecondFibonacci)
            {
                return "yes, both numbers";
            }
            else if (IsFirstFibonacci)
            {
                return "yes, first number";
            }
            else if (IsSecondFibonacci)
            {
                return "yes, second number";
            }
            else
            {
                return "no";
            }
        }
       static bool IsFibonacci(int number)
        {

            if (number < 0) return false;
            return IsPerfectSquare(5 * number * number + 4) || IsPerfectSquare(5 * number * number - 4);
        }
       static bool IsPerfectSquare(int x)
        {
            int s = (int)Math.Sqrt(x);
            return (s * s == x);

        }   
                
               
      
    //public static string CheckIfSumIsPrime(int firstNumber, int secondNumber)
    //    {
    //        throw new NotImplementedException();
        

    

