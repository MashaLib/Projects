
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
            throw new NotImplementedException();
        }

        public static string CheckIfSumIsPrime(int firstNumber, int secondNumber)
        {
            int uresult = firstNumber + secondNumber;
            if (uresult == 0 || uresult == 1)
            {
                Console.WriteLine(uresult + " is not a prime number!");
                Console.ReadLine();
            }
            else
            {
                for (int i = 2; i <= uresult / 2; i++)
                {
                    if (uresult % i == 0)
                    {
                        Console.WriteLine(uresult + " is not a prime number");
                        Console.ReadLine();
                        return uresult.ToString();
                    }
                }
                Console.WriteLine(uresult + " is a prime number!");
            }
            return uresult.ToString();
        }
    }
}
