namespace BASICS
{
  // Switch - Case
  public static class BASICS09
  {
    public static void MainCode()
    {
      Random rnd = new Random();

      int caseSwitch = rnd.Next(1, 5);

      switch (caseSwitch)
      {
        case 1:
          Console.WriteLine("Case 1");
          break;
        case 2:
        case 3:
          Console.WriteLine($"Case {caseSwitch}");
          break;
        default:
          Console.WriteLine($"Unexpected case {caseSwitch}");
          break;
      }
    }
  }
}