namespace BASICS
{
  public static class BASICS05
  {
    public static void MainCode()
    {
      var a = 3;
      var b = 2;
      Console.WriteLine(a + b);

      var x = "3";
      var y = "2";
      Console.WriteLine(x + y);

      // this equals to 33000000
      int i = 33_000_000;
      Console.WriteLine(i);

      object num = 10;
      Console.WriteLine($"Type of num object is {num.GetType()}");

      // num = num + 10; // not allowed
      dynamic dynamic_num = 10;
      dynamic_num = dynamic_num + 10; // allowed
      Console.WriteLine(dynamic_num);
    }
  }
}
