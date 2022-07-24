namespace BASICS
{

  public static class BASICS10
  {
    public static void MainCode()
    {
      Console.WriteLine("Provide a number:");
      int n = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("");

      if (Number.IsOdd(n))
        Console.WriteLine($"{n} is odd.");
      if (Number.IsEven(n))
        Console.WriteLine($"{n} is even.");
      Console.WriteLine("|{0}| = {1}", n, Number.AbsoluteValue(n));
      Console.WriteLine("{0} is {1}", n, Number.IsPrimeNumber(n) ? "a prime number." : "NOT a prime number.");
      Console.WriteLine("The sum of the digits of {0} is {1}", n, Number.SumOfDigits(n));
      Console.WriteLine("The sum of the numbers from 0 to {0} = {1}", n, Number.SumOfNumbersUntilN(n));
      Console.WriteLine("The sum of the numbers from 0 to {0} (using formula) = {1}", n, Number.SumOfNumbersUntilNUsingFormula(n));
      Console.WriteLine("The sum of odd numbers from 0 to {0} = {1}", n, Number.SumOfOddNumbersUntilN(n));
      Console.WriteLine("The sum of odd numbers from 0 to {0} (alternative) = {1}", n, Number.SumOfOddNumbersUntilNAlternativeSolution(n));
      Console.WriteLine("The sum of odd numbers from 0 to {0} (alternative) = {1}", n, Number.SumOfOddNumbersUntilNUsingFormula(n));
      Console.WriteLine("The sum of even numbers from 0 to {0} (alternative) = {1}", n, Number.SumOfEvenNumbersUntilNUsingFormula(n));
    }

    public class Number
    {
      /// <summary>
      /// Checks if provided number is odd
      /// </summary>
      /// <param name="n">Number</param>
      /// <returns>If odd returns true else returns false</returns>
      public static bool IsOdd(int n)
      {
        if (n % 2 == 1)
          return true;
        return false;
      }

      /// <summary>
      /// Checks if provided number is even
      /// </summary>
      /// <param name="n">Number</param>
      /// <returns>If even returns true else returns false</returns>
      public static bool IsEven(int n)
      {
        if (n % 2 == 0)
          return true;
        return false;
      }

      /// <summary>
      /// Returns absolute value of provided number
      /// </summary>
      /// <param name="n">Number</param>
      /// <returns>Absolute value of provided number</returns>
      public static int AbsoluteValue(int n)
      {
        if (n >= 0)
          return n;
        else
          return -1 * n;
      }

      /// <summary>
      /// Checks if provided number is a prime number
      /// </summary>
      /// <param name="n">Number</param>
      /// <returns>If prime number returns true else returns false</returns>
      public static bool IsPrimeNumber(int n)
      {
        if (n <= 1)
        {
          Console.WriteLine("The smallest prime number is 2.");
          return false;
        }

        bool isPrime = true;
        for (int i = 2; i < n; i++)
          if (n % i == 0)
          {
            isPrime = false;
            break;
          }
        return isPrime;
      }

      /// <summary>
      /// Returns the sum of the digits of provided number
      /// </summary>
      public static int SumOfDigits(int n)
      {
        int sum = 0, digit = 0;
        n = AbsoluteValue(n);
        while (n > 0)
        {
          digit = n % 10;
          sum += digit;
          n = n / 10;
        }
        return sum;
      }

      // Sum of Numbers Until (including) n
      // First solution
      // expensive calculation
      // bug: doesn't work with negative numbers
      public static int SumOfNumbersUntilN(int n)
      {
        int sum = 0;
        for (int i = 1; i <= n; i++)
          sum += i;
        return sum;
      }

      // Second (better) solution
      // works with negative numbers
      public static int SumOfNumbersUntilNUsingFormula(int n)
      {
        return (n * (n + 1)) / 2;
      }

      // Sum of Odd Numbers Until (including) n
      // First solution
      // expensive calculation
      // bug: doesn't work with negative numbers
      public static int SumOfOddNumbersUntilN(int n)
      {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
          if (i % 2 == 1)
            sum += i;
        }
        return sum;
      }

      // Second (better) solution
      // still expensive calculation
      // bug: doesn't work with negative numbers
      public static int SumOfOddNumbersUntilNAlternativeSolution(int n)
      {
        int sum = 0;
        for (int i = 1; i <= n; i += 2)
          sum += i;
        return sum;
      }


      // Third (best) solution using formula
      // works with negative numbers
      public static int SumOfOddNumbersUntilNUsingFormula(int n)
      {
        // Formula:
        // 1 + 3 + 5 + ... + n = 2n + 1
        n = (n + 1) / 2; // find n
        return n * n;
      }

      // Sum of Even Numbers Until (including) n
      public static int SumOfEvenNumbersUntilNUsingFormula(int n)
      {
        // Formula:
        // 2 + 4 + 6 + ... + 2n = n * (n + 1);
        n = n / 2; // find n
        return n * (n + 1);
      }
    }
  }
}