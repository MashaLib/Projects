
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LearnLab.NumberOperations
{
    public class DigitOperations
    {
      
        public static string CalculateSumOfDigits(int firstNumber, int secondNumber)
        {
            // The sum of the digits of both {firstNumber} and {secondNumber} together is:

            int sum = 0;

            Math.Abs(firstNumber);
            Math.Abs(secondNumber);

            if ((firstNumber < 10 & firstNumber >= 0) & (secondNumber < 10 & secondNumber >= 0))
            {
                sum = firstNumber + secondNumber;    
            }

            int[] firstDigits = SplitNumberIntoIntArray(firstNumber);
            int[] secondDigits = SplitNumberIntoIntArray(secondNumber);

            for (int i = 0; i < firstDigits.Length; i++)
            {
                sum += firstDigits[i];
            }

            for (int i = 0; i < secondDigits.Length; i++)
            {
                sum += secondDigits[i];
            }

            return sum.ToString();
        }

        public static int[] SplitNumberIntoIntArray(int number)
        {
            int[] digits = Math.Abs(number)
                            .ToString()               
                            .Select(x => (int)char.GetNumericValue(x)) 
                            .ToArray();           
            return digits;
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
