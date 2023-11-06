using System;

public class Test
{
    public static double Harmonic(double a, double b)
    {
        double res = (2 / ((1 / a) + (1 / b)));
        return res;
    }
    public static double Heometric(double a, double b)
    {
        double res = Math.Sqrt(a * b);
        return res;
    }
    public static double Arifmetic(double a, double b)
    {
        double res = (a + b) / 2;
        return res;
    }
    public static double Qubic(double a, double b)
    {
        double res = Math.Sqrt((a * a) + (b * b)) / Math.Sqrt(2);
        return res;
    }
    public static void Main()
    {
        string[] str = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(str[0]);
        int b = Convert.ToInt32(str[1]);

        Console.WriteLine(Harmonic(a, b));
        Console.WriteLine(Heometric(a, b));
        Console.WriteLine(Arifmetic(a, b));
        Console.WriteLine(Qubic(a, b));
    }
}
