namespace BASICS // Note: actual namespace depends on the project name.
{
  public static class BASICS02
  {
    public static void MainCode()
    {
      Console.WriteLine("Hello World!");

      int min, max;
      min = System.Int16.MinValue;
      max = System.Int16.MaxValue;

      int min32 = System.Int32.MinValue;
      int max32 = System.Int32.MaxValue;

      byte minByte = System.Byte.MinValue;
      byte maxByte = System.Byte.MaxValue;

      int number = 23;
      Console.WriteLine(number);
      Console.WriteLine("Int16 -> Min : {0} \t\t Max : {1}", min, max);
      Console.WriteLine("Int32 -> Min : {0} \t Max : {1}", min32, max32);
      Console.WriteLine("Byte -> Min : {0} \t\t Max : {1}", minByte, maxByte);
    }
  }
}