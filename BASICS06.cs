namespace BASICS
{
  public static class BASICS06
  {
    public static void MainCode()
    {
      var x = 3; // Implicitly typed
      int y = 2; // Explicitely typed
      Console.WriteLine($"Type of var x = {x.GetType()}");
      Console.WriteLine($"Type of int y = {y.GetType()}");

      string[] fruits = { "apple", "banana", "grape", "peach", "pear" };
      var fruit = from f in fruits
                  where f[0] == 'a'
                  select f;
      Console.WriteLine($"Type of var fruit = {fruit.GetType()}");

      foreach (string f in fruit)
        Console.WriteLine(f);
    }
  }
}
