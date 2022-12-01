namespace BASICS
{
  // Math
  public class BASICS17
  {
    public static void MainCode()
    {
      // Console.WriteLine("Provide base: ");
      // double num1 = Convert.ToDouble(Console.ReadLine());
      // Console.WriteLine("Provide exponent: ");
      // double num2 = Convert.ToDouble(Console.ReadLine());
      // Console.WriteLine("{0}^{1} = {2}", num1, num2, Power(num1, num2));

      // foreach (int multiplier in PrimeMultipliers(60))
      // {
      //   Console.Write("{0,5}", multiplier);
      // }

      // Console.WriteLine();

      // foreach (int multiplier in PrimeMultipliers(32))
      // {
      //   Console.Write("{0,5}", multiplier);
      // }
      // Console.WriteLine();

      Console.WriteLine("Provide a number: ");
      int num3 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Sum of prime multipliers of {0} = {1}", num3, SumOfPrimeMultipliers(num3));

      Console.WriteLine("Provide a number: ");
      int num4 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Multiply prime multipliers of {0} = {1}", num4, MultiplyPrimeMultipliers(num4));
    }

    public static double Power(double powerBase, double exponent)
    {
      double result = 1;
      for (int i = 1; i <= exponent; i++)
      {
        result *= powerBase;
      }
      return result;
    }

    public static int[] PrimeMultipliers(int n)
    {
      string multiplierList = "";
      int firstPrimeNum = 2;

      while (n > 1)
      {
        if (n % firstPrimeNum == 0)
        {
          n = n / firstPrimeNum;
          multiplierList += firstPrimeNum.ToString() + ',';
        }
        else
          firstPrimeNum++;
      }

      multiplierList = multiplierList.Substring(0, multiplierList.Length - 1);
      string[] multipliers = multiplierList.Split(",");

      string currentMultiplier = multipliers[0];
      string uniqueMultipliers = currentMultiplier;

      for (int i = 0; i < multipliers.Length; i++)
      {
        if (!(currentMultiplier == multipliers[i]))
        {
          uniqueMultipliers += "," + multipliers[i];
          currentMultiplier = multipliers[i];
        }
      }

      string[] uniqueMultiplierList = uniqueMultipliers.Split(",");
      int[] result = new int[uniqueMultiplierList.Length];

      for (int j = 0; j < uniqueMultiplierList.Length; j++)
      {
        result[j] = Convert.ToInt32(uniqueMultiplierList[j]);
      }

      return result;
    }

    public static int SumOfPrimeMultipliers(int n)
    {
      int total = 0;
      int[] primeMultipliers = PrimeMultipliers(n);
      for (int i = 0; i < primeMultipliers.Length; i++)
      {
        total += primeMultipliers[i];
      }
      return total;
    }

    public static int MultiplyPrimeMultipliers(int n)
    {
      int result = 1;
      int[] primeMultipliers = PrimeMultipliers(n);
      for (int i = 0; i < primeMultipliers.Length; i++)
      {
        result *= primeMultipliers[i];
      }
      return result;
    }
  }
}