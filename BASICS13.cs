namespace BASICS
{

  // For loop
  public static class BASICS13
  {
    public static void MainCode()
    {
      // Example 1

      // for (int i = 0; i <= 100; i++)
      // {
      //   Console.WriteLine("{0,5} -> {1,5}", i, i * i);
      // }

      // for (int i = 5; i <= 100; i += 5)
      // {
      //   Console.WriteLine("{0,5} -> {1,5}", i, i * i);
      // }

      // for (int i = 100; i > 0; i -= 5)
      // {
      //   Console.WriteLine("{0,5} -> {1,5}", i, i * i);
      // }


      // Example 2

      // int oddSum = 0, evenSum = 0;
      // System.Console.WriteLine("Limit? :");
      // int limit = Convert.ToInt32(Console.ReadLine());

      // Console.WriteLine("Odd numbers");
      // for (int i = 1; i <= limit; i += 2)
      // {
      //   Console.Write("{0,5}", i);
      //   oddSum += i;
      // }

      // Console.WriteLine("\n\nEven numbers");
      // for (int i = 2; i <= limit; i += 2)
      // {
      //   Console.Write("{0,5}", i);
      //   evenSum += i;
      // }

      // System.Console.WriteLine("\n\nOdd sum: {0,5}\nEven toplam: {1,5}", oddSum, evenSum);


      // Example 3

      // int counter = 0;
      // for (int i = 1000; i > 0; i -= 5)
      // {
      //   Console.Write("{0,5}", i);
      //   counter++;
      // }

      // Console.WriteLine($"\n\nCount: {counter}");


      // Example 4

      for (int i = 1; i <= 10; i++)
      {
        for (int j = 1; j <= 10; j++)
        {
          Console.WriteLine("{0,5} \tx {1,5} = {2,5}", j, i, i * j);
        }
        Console.WriteLine("\n ------------------------------- \n");
      }
    }
  }
}