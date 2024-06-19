using System;

public class Program
{
    public static void Main()
    {
        double radius = 5.0;
        double area = CalculateCircleArea(radius);
        Console.WriteLine("The area of the circle is: " + area);
    }

    public static double CalculateCircleArea(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
}