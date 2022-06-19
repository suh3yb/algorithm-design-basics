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

        bool kontrol = true;
        for (int i = 2; i < n; i++)
          if (n % i == 0)
          {
            kontrol = false;
            break;
          }
        return kontrol;
      }

      /// <summary>
      /// Returns the sum of the digits of provided number
      /// </summary>
      public static int SumOfDigits(int n)
      {
        int sum = 0, digit = 0;
        while (n > 0)
        {
          digit = n % 10;
          sum += digit;
          n = n / 10;
        }
        return sum;
      }

      public static int SumOfNumbersUntilN(int n)
      {
        int total = 0;
        for (int i = 0; i <= n; i++)
          total += i;
        return total;
      }

      public static int SumOfNumbersUntilNUsingFormula(int n)
      {
        return (n * (n + 1)) / 2;
      }
    }
  }
}