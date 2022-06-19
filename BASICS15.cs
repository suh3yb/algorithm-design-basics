namespace BASICS
{

  // Char
  public class BASICS15
  {
    public static void MainCode()
    {
      // Uppercase letters
      for (int i = 65; i <= 90; i++)
      {
        Console.Write("{0, 5}", (char)i);
      }

      Console.WriteLine("\n\n");

      for (int i = 32; i <= 126; i++)
      {
        Console.Write("{0, 5}", (char)i);
        if (i % 5 == 0)
          Console.WriteLine("");
      }
    }
  }
}