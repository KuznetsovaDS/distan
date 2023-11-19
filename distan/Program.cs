using System;
public struct Distance
{
    public int feet;
    public int inch;

}
class Program
{
    static void Main()
    {
        Distance x, y, z;
        Console.Write("Enter first lengh ");
        Console.Write("\n Enter feet ");
        x.feet = int.Parse(Console.ReadLine());
        Console.Write("Enter inch ");
        x.inch = int.Parse(Console.ReadLine());
        Console.Write("Enter secons lengh ");
        Console.Write("\n Enter feet ");
        y.feet = int.Parse(Console.ReadLine());
        Console.Write("Enter inch ");
        y.inch = int.Parse(Console.ReadLine());

        z.feet = (x.feet + y.feet) + (x.inch + y.inch) / 12;
        z.inch = (x.inch + y.inch) % 12;

        Console.WriteLine("Result is  " + "{0}'-{1}\"", z.feet, z.inch);
    }
}