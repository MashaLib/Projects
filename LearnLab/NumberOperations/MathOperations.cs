
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
            
            
                
                bool IsFibonacci(int number)
                {
                    bool IsPerfectSquare(int n)
                    {
                        int sqrt = (int)Math.Sqrt(n);
                        return sqrt * sqrt == n;
                    }

                    return IsPerfectSquare(5 * number * number + 4) || IsPerfectSquare(5 * number * number - 4);
                }

               
                bool isFirstFibonacci = IsFibonacci(firstNumber);
                bool isSecondFibonacci = IsFibonacci(secondNumber);

              
                if (isFirstFibonacci && isSecondFibonacci)
                {
                    return "yes, both numbers";
                }
                else if (isFirstFibonacci)
                {
                    return "yes, first number";
                }
                else if (isSecondFibonacci)
                {
                    return "yes, second number";
                }
                else
                {
                    return "no";
                }
            }
        }

    }

    //public static string CheckIfSumIsPrime(int firstNumber, int secondNumber)
    //    {
    //        throw new NotImplementedException();
        

    

