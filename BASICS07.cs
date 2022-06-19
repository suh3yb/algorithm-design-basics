namespace BASICS
{
  public static class BASICS07
  {
    public static void MainCode()
    {
      Console.WriteLine("Provide a letter: ");
      char ch = (char)Console.Read();

      if (Char.IsUpper(ch))
      {
        Console.WriteLine("An uppercase letter provided.");
      }
      else if (Char.IsLower(ch))
      {
        Console.WriteLine("A lowercase letter provided.");

      }
      else if (Char.IsDigit(ch))
      {
        Console.WriteLine("A digit provided.");
      }
      else
      {
        Console.WriteLine("No letter or digit provided.");
      }
    }
  }
}