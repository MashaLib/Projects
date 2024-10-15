using LearnLab.NumberOperations;

namespace LearnLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DisplayOperations();
                OperationOptionsEnum choice = GetOperationChoice();
                int firstNumber = GetValidInteger("Enter the first number:");
                int secondNumber = GetValidInteger("Enter the second number:");
                ExecuteOperation(choice, firstNumber, secondNumber);
                if (!Continue())
                    break;
            }
        }
        static void DisplayOperations()
        {
            Console.WriteLine("Choose an operation (please enter the operation number):");
            foreach (var item in Enum.GetValues<OperationOptionsEnum>())
            {
                Console.WriteLine($"{(int)item} - {item}");
            }
        }

        static OperationOptionsEnum GetOperationChoice()
        {
            OperationOptionsEnum choice;

            while (true)
            {
                if (Enum.TryParse(Console.ReadLine(), out choice))
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid operation number.");
                }
            }
        }

        static int GetValidInteger(string message)
        {
            int result;
            while (true)
            {
                Console.WriteLine(message);
                if (int.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }

        static void ExecuteOperation(OperationOptionsEnum choice, int firstNumber, int secondNumber)
        {
            try
            {
                switch (choice)
                {
                    case OperationOptionsEnum.AddNumbers:
                        Console.WriteLine($"The result of adding {firstNumber} and {secondNumber} is: {MathOperations.CalculateAddition(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.SubtractNumbers:
                        Console.WriteLine($"The result of subtracting {secondNumber} from {firstNumber} is: {MathOperations.CalculateSubtraction(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.MultiplyNumbers:
                        Console.WriteLine($"The result of multiplying {firstNumber} and {secondNumber} is: {MathOperations.CalculateMultiplication(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.DivideNumbers:
                        Console.WriteLine($"The result of dividing {firstNumber} by {secondNumber} is: {MathOperations.CalculateDivision(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.DivideWithRemainder:
                        Console.WriteLine($"The result of dividing {firstNumber} by {secondNumber} with remainder is: {MathOperations.CalculateDivisionWithRemainder(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.RaiseToPower:
                        Console.WriteLine($"{firstNumber} raised to the power of {secondNumber} is: {MathOperations.CalculatePower(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.FindAverageOfNumbers:
                        Console.WriteLine($"The average of {firstNumber} and {secondNumber} is: {MathOperations.CalculateAverage(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.FindFactorialOfSum:
                        Console.WriteLine($"The factorial of the sum of {firstNumber} and {secondNumber} is: {MathOperations.CalculateFactorialOfSum(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.CheckIfNumberIsFibonacci:
                        Console.WriteLine($"Are {firstNumber} or {secondNumber} Fibonacci numbers? {MathOperations.CheckIfNumbersAreFibonacci(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.CheckIfSumIsPrime:
                        Console.WriteLine($"Is the sum of {firstNumber} and {secondNumber} a prime number? {MathOperations.CheckIfSumIsPrime(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.FindSumOfDigits:
                        Console.WriteLine($"The sum of the digits of both {firstNumber} and {secondNumber} together is: {DigitOperations.CalculateSumOfDigits(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.CountDigitsInNumbers:
                        Console.WriteLine($"The number of digits in both {firstNumber} and {secondNumber} together is: {DigitOperations.CountDigits(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.FindLeastAndGreatestDigit:
                        Console.WriteLine($"The least and greatest digits in both {firstNumber} and {secondNumber} together are: {DigitOperations.FindLeastAndGreatestDigit(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.SortDigitsInNumbers:
                        Console.WriteLine($"The sorted digits of both {firstNumber} and {secondNumber} together are: {DigitOperations.SortDigits(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.ZigzagMergeOfNumbers:
                        Console.WriteLine($"The Zigzag Merge result of {firstNumber} and {secondNumber} is: {DigitOperations.PerformZigzagMerge(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.CheckIfNumbersAreMirrors:
                        Console.WriteLine($"Are {firstNumber} and {secondNumber} mirror images? {DigitOperations.CheckIfNumbersAreMirrors(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.CheckIfNumbersAreDigitAnagrams:
                        Console.WriteLine($"Are {firstNumber} and {secondNumber} digit anagrams? {DigitOperations.CheckIfNumbersAreDigitAnagrams(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.FindCommonDigitsBetweenNumbers:
                        Console.WriteLine($"The common digits between {firstNumber} and {secondNumber} are: {DigitOperations.FindCommonDigits(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.FindUniqueDigitsBetweenNumbers:
                        Console.WriteLine($"The unique digits between {firstNumber} and {secondNumber} are: {DigitOperations.FindUniqueDigits(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.CompareTwoNumbers:
                        Console.WriteLine($"The {firstNumber} is  {LogicOperations.CompareNumbers(firstNumber, secondNumber)} than {secondNumber} ");
                        break;
                    case OperationOptionsEnum.GetPercentageRatioOfSum:
                        Console.WriteLine($"The percentage ratio of {firstNumber} and {secondNumber} in their sum is: {LogicOperations.CalculatePercentageRatioOfSum(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.FindGreatestCommonDivisorOfNumbers:
                        Console.WriteLine($"The greatest common divisor (GCD) of {firstNumber} and {secondNumber} is: {LogicOperations.CalculateGCD(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.FindLeastCommonMultipleOfNumbers:
                        Console.WriteLine($"The least common multiple (LCM) of {firstNumber} and {secondNumber} is: {LogicOperations.CalculateLCM(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.CheckIfSumIsEvenOrOdd:
                        Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {LogicOperations.CheckIfSumIsEvenOrOdd(firstNumber, secondNumber)}");
                        break;
                    case OperationOptionsEnum.CheckIfSumIsPerfectSquare:
                        Console.WriteLine($"Is the sum of {firstNumber} and {secondNumber} a perfect square? {LogicOperations.CheckIfSumIsPerfectSquare(firstNumber, secondNumber)}");
                        break;
                    default:
                        Console.WriteLine("Operation not implemented yet.");
                        break;
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }

        static bool Continue()
        {
            Console.WriteLine("\nWould you like to perform another operation? (y/n)");
            return Console.ReadLine().ToLower() == "y";
        }
    }
}
