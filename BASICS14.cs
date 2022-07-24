namespace BASICS
{

  // Array
  public class BASICS14
  {
    public static void MainCode()
    {
      Console.WriteLine("Provide a limit:");
      int length = Convert.ToInt32(Console.ReadLine());
      int[] numbers = new Array().Create(length);

      Console.WriteLine("\n\nBiggest number: {0}", Array.FindBiggest(numbers));
      Console.WriteLine("\nSmallest number: {0}", Array.FindSmallest(numbers));
      Console.WriteLine("\nArithmetic mean: {0:F2}", Array.CalculateArithmeticMean(numbers));
      Console.WriteLine("\nStandard Deviation: {0:F2}", Array.CalculateStandardDeviation(numbers));

      Array array = new Array();
      int[] oddNumbersArr = array.CreateOddOnlyArray(numbers);
      Array.PrintElements(oddNumbersArr);
      Console.WriteLine("Number of odd numbers: {0,5}", array.NumberOfOddNumbers(numbers));

      int[] evenNumbersArr = array.CreateEvenOnlyArray(numbers);
      Array.PrintElements(evenNumbersArr);
      Console.WriteLine("Number of even numbers: {0,5}", array.NumberOfEvenNumbers(numbers));
    }
  }

  public class Array
  {
    /// <summary>
    /// Creates one dimensional arrays of random numbers
    /// </summary>
    /// <param name="length">Length of array</param>
    /// <returns>Array of random numbers with provided length</returns>
    public int[] Create(int length)
    {
      int[] numbers = new int[length];
      Console.WriteLine("");
      for (int i = 0; i < length; i++)
      {
        numbers[i] = new Random().Next(1, 100);
        Console.Write("{0,5}", numbers[i]);
      }
      Console.WriteLine("");
      return numbers;
    }

    public static int FindBiggest(int[] array)
    {
      int biggest = array[0];
      for (int i = 1; i < array.Length; i++)
      {
        if (array[i] > biggest)
          biggest = array[i];
      }
      return biggest;
    }

    public static int FindSmallest(int[] array)
    {
      int smallest = array[0];
      for (int i = 1; i < array.Length; i++)
      {
        if (array[i] < smallest)
          smallest = array[i];
      }
      return smallest;
    }

    public static double CalculateArithmeticMean(int[] array)
    {
      double sum = 0;
      for (int i = 0; i < array.Length; i++)
        sum += array[i];
      return sum / array.Length;
    }

    public static double CalculateStandardDeviation(int[] array)
    {
      double arithmeticMean = CalculateArithmeticMean(array);
      double t = 0, d = 0;

      for (int i = 0; i < array.Length; i++)
      {
        d = array[i] - arithmeticMean;
        t += Math.Pow(d, 2);
      }

      return Math.Sqrt(t / (array.Length - 1));
    }

    public int NumberOfOddNumbers(int[] array)
    {
      int numberOfOddNumbers = 0;
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] % 2 == 1)
          numberOfOddNumbers++;
      }
      return numberOfOddNumbers;
    }

    public int NumberOfEvenNumbers(int[] array)
    {
      int numberOfEvenNumbers = 0;
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] % 2 == 0)
          numberOfEvenNumbers++;
      }
      return numberOfEvenNumbers;
    }

    public int[] CreateOddOnlyArray(int[] array)
    {
      int[] oddOnlyArr = new int[NumberOfOddNumbers(array)];
      int index = 0;

      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] % 2 == 1)
        {
          oddOnlyArr[index] = array[i];
          index++;
        }
      }
      return oddOnlyArr;
    }

    public int[] CreateEvenOnlyArray(int[] array)
    {
      int[] evenOnlyArr = new int[NumberOfEvenNumbers(array)];
      int index = 0;

      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] % 2 == 0)
        {
          evenOnlyArr[index] = array[i];
          index++;
        }
      }
      return evenOnlyArr;
    }

    public static void PrintElements(int[] array)
    {
      Console.WriteLine("");
      for (int i = 0; i < array.Length; i++)
      {
        Console.Write("{0,3}", array[i]);
      }
      Console.WriteLine("");
    }
  }
}