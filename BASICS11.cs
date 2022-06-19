namespace BASICS
{

  public static class BASICS11
  {
    public static void MainCode()
    {
      // Find sum of even numbers between 50 and (including) 80
      int sumUntil48 = BASICS10.Number.SumOfEvenNumbersUntilNUsingFormula(48);
      int sumUntil80 = BASICS10.Number.SumOfEvenNumbersUntilNUsingFormula(80);
      Console.WriteLine("Sum of even numbers between 50 and 80: ");
      Console.WriteLine("{0} - {1} = {2}", sumUntil80, sumUntil48, sumUntil80 - sumUntil48);
    }
  }
}