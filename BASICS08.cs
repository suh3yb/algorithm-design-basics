namespace BASICS
{
  // Switch - Case
  public static class BASICS08
  {
    public enum Colors { Red, Green, Blue };
    public static void MainCode()
    {
      Colors c = (Colors)(new Random()).Next(0, 4);

      switch (c)
      {
        case Colors.Red:
          Console.WriteLine("Red");
          break;
        case Colors.Green:
          Console.WriteLine("Green");
          break;
        case Colors.Blue:
          Console.WriteLine("Blue");
          break;
        default:
          Console.WriteLine("{0} is Unknown", c);
          break;
      }
    }
  }
}