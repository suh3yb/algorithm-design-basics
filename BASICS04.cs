namespace BASICS // Note: actual namespace depends on the project name.
{
  public class BASICS04
  {
    // readonly static int year = 2022; // won't work in 2023
    readonly int year;

    public BASICS04()
    {
      year = DateTime.Now.Year;
      Console.WriteLine("Year: {0}", year);
    }

    public static void CalculateCircleArea()
    {
      const double pi = 3.1428;
      Double area, r;

      Console.WriteLine("r =");
      r = Convert.ToDouble(Console.ReadLine());

      area = pi * r * r;
      Console.WriteLine("Area for r={0} is {1}", r, area);
      Console.Read();
    }

    public static void CalculateAge()
    {
      int current_year = new BASICS04().year;

      Console.WriteLine("Year of birth :");
      int year_of_birth = Convert.ToInt16(Console.ReadLine());

      Console.WriteLine("Your age : {0}", current_year - year_of_birth);
      Console.ReadKey();
    }

    public static void MainCode()
    {
      // static can't be used with const
      // static const int c = 23;

      var mC = new SampleClass(11, 22);

      Console.WriteLine($"x = {mC.x}, y = {mC.y}");
      Console.WriteLine($"C1 = {SampleClass.C1}, C2 = {SampleClass.C2}");
    }
  }

  class SampleClass
  {
    public int x;
    public int y;

    public const int C1 = 5;
    public const int C2 = C1 + 5;

    public SampleClass(int p1, int p2)
    {
      x = p1;
      y = p2;
    }
  }
}