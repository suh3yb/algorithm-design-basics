namespace BASICS
{
  public static class BASICS03
  {
    // boxing, unboxing, cast
    public static void MainCode()
    {
      // boxing
      int i = 23;
      object o = i;
      // object o = (object)i; // explicit boxing

      // unboxing
      i *= 2;
      i = (int)o; // cast

      Console.WriteLine("Actual var : {0}", i);
      Console.WriteLine("Reference : {0}", o);
    }
  }
}