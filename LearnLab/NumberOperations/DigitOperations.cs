
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
            throw new NotImplementedException();
        }

        public static string SortDigits(int firstNumber, int secondNumber)
        {
            string combinedDigits = (firstNumber < 0 ? -firstNumber : firstNumber).ToString() +
                         (secondNumber < 0 ? -secondNumber : secondNumber).ToString();
            char[] digitsArray = combinedDigits.ToCharArray();
            Array.Sort(digitsArray);
            return string.Concat(digitsArray);
        }
      
    }
}
