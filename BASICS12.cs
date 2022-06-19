namespace BASICS
{

  public static class BASICS12
  {
    public static void CalculateCircumferenceOfCircle()
    {
      Console.WriteLine("Provide r:");
      double r = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("\nCircumference: \t\t 2 * {0:F2} * {1:F2} = {2:F2}", Circle.pi, r, Circle.CalculateCircumference(r));
      Console.WriteLine("Area: \t\t\t {0:F2} * {1:F2} * {1:F2} = {2:F2}", Circle.pi, r, Circle.CalculateArea(r));
      Console.WriteLine("Area of 60 degrees: \t {0:F2}", Circle.CalculateArea(r, 60));
    }
  }

  public static class Circle
  {
    public const double pi = 3.14;

    public static double CalculateCircumference(double r)
    {
      return 2 * pi * r;
    }

    public static double CalculateArea(double r)
    {
      return pi * r * r;
    }

    public static double CalculateArea(double r, double angle)
    {
      return pi * r * r * angle / 360;
    }
  }
}