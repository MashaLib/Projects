
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
            char[] firstDigit = firstNumber.ToString().ToCharArray();
            char[] secondDigit = secondNumber.ToString().ToCharArray();

            HashSet<char> uniqueDigits = new HashSet<char>();

            foreach (char c in firstDigit)
            {
                if (!secondDigit.Contains(c))
                {
                    uniqueDigits.Add(c);
                }
            }
            foreach (char c in secondDigit)
            {
                if (!firstDigit.Contains(c))
                {
                    uniqueDigits.Add(c);
                }
            }
            return new string(uniqueDigits.ToArray());
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
