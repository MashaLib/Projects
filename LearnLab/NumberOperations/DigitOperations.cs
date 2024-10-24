
namespace LearnLab.NumberOperations
{
    public class DigitOperations
    {
        public static string CalculateSumOfDigits(int firstNumber, int secondNumber)
        {
            // The sum of the digits of both {firstNumber} and {secondNumber} together is:

            string result = string.Empty;

            if(firstNumber > 0 & secondNumber > 0)
            {
                result = CalculateSumOfPositiveDigits(firstNumber, secondNumber);
            }

            return result;
        }

        public static string CalculateSumOfPositiveDigits(int firstNumber, int secondNumber)
        {

            int[] digits = firstNumber.ToString()
                    .Select(x => int.Parse(x.ToString()))
                    .Concat(secondNumber.ToString()
                                .Select(x => int.Parse(x.ToString())))
                    .ToArray();

            int sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                sum += digits[i];
            }

            return sum.ToString();
        }

        public static string CheckIfNumbersAreDigitAnagrams(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        public static string CheckIfNumbersAreMirrors(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        public static string CountDigits(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }
        
        public static string FindCommonDigits(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        public static string FindLeastAndGreatestDigit(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        public static string FindUniqueDigits(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }
        
        public static string PerformZigzagMerge(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        public static string SortDigits(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }
      
    }
}
