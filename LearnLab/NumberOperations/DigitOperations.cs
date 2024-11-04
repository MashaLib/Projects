
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
            string result = "NO";

            string firstNumberString = firstNumber.ToString();
            string secondNumberString = secondNumber.ToString();

            if (firstNumberString.Length != secondNumberString.Length) 
            {
                return result;
            }

            int checkLength = 0;
            
            for (int i = 0; i < firstNumberString.Length; i++)
            {
                for (int j = 0; j < secondNumberString.Length; j++)
                {
                    if (firstNumberString[i] == secondNumberString[j] & checkLength < firstNumberString.Length) 
                    {
                        checkLength++;
                        break;
                    }
                }
            }

            if (checkLength == firstNumberString.Length) 
            {
               result = "YES";
            }

            return result;
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
