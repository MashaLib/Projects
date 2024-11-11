
using System.Text;

namespace LearnLab.NumberOperations
{
    public class DigitOperations
    {
        public static string CalculateSumOfDigits(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
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
            char[] firstDigit = firstNumber.ToString().ToCharArray();
            char[] secondDigit = secondNumber.ToString().ToCharArray();

            StringBuilder result = new StringBuilder();

            int maxLenght = Math.Max(firstDigit.Length, secondDigit.Length);

            for (int i = 0; i < maxLenght; i++)
            {
                if (i < firstDigit.Length)
                {
                    result.Append(firstDigit[i]);
                }
                if (i < secondDigit.Length)
                {
                    result.Append(secondDigit[i]);
                }
            }
            return result.ToString();
        }

        public static string SortDigits(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }
      
    }
}
