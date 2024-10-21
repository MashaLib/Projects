
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            string digitsOfFirstNumber = firstNumber.ToString();
            string digitsOfSecondNumber = secondNumber.ToString();

            List<char> commonDigits = new List<char>();

            for (int i = 0; i < digitsOfFirstNumber.Length; i++)
            {
                for (int j = 0; j < digitsOfSecondNumber.Length; j++)
                {
                    if (digitsOfFirstNumber[i] == digitsOfSecondNumber[j])
                    {
                        if (commonDigits.Contains(digitsOfFirstNumber[i]))
                        {
                            continue;
                        }
                        commonDigits.Add(digitsOfFirstNumber[i]);
                        break;
                    }
                }
            }

            string result = string.Join(", ", commonDigits);

            return result;
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
