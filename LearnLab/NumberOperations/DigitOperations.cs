
using System.Collections.Generic;

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
            string combinedDigits = (firstNumber < 0 ? -firstNumber : firstNumber).ToString() +
                        (secondNumber < 0 ? -secondNumber : secondNumber).ToString(); // checkinmg for  negatives
            int leastDigit = 9;
            int greatestDigit = 0;
            foreach (char digitChar in combinedDigits)
            {
                int digit = digitChar - '0'; //unicode - 0 (48) to int
                if (digit < leastDigit) leastDigit = digit;
                if (digit > greatestDigit) greatestDigit = digit;
            }
            return $"Least digit: {leastDigit}, Greatest digit: {greatestDigit}";

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
