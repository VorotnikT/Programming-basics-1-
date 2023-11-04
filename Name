using System;


public class Test


{
    public static double CalcDistance(double x1, double y1, double x2, double y2)
    {
        double Distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        return Distance;
    }

    public static double CalcPerimetr(double a, double b, double c)
    {
        return a + b + c;
    }

    public static double CalcHalfPerimeter(double a, double b, double c)
    {
        return CalcPerimetr(a, b, c) / 2.0;
    }

    public static double Heron(double a, double b, double c)
    {
        double p = CalcHalfPerimeter(a, b, c);
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    public static void Main()
    {
        string[] str = Console.ReadLine().Split(' ');
        double x1 = double.Parse(str[0]);
        double y1 = double.Parse(str[1]);

        string[] str1 = Console.ReadLine().Split(' ');
        double x2 = double.Parse(str[0]);
        double y2 = double.Parse(str[1]);

        string[] str2 = Console.ReadLine().Split(' ');
        double x3 = double.Parse(str[0]);
        double y3 = double.Parse(str[1]);

        double a = CalcDistance(x1, y1, x2, y2);
        double b = CalcDistance(x3, y3, x2, y2);
        double c = CalcDistance(x1, y1, x3, y3);



    
        Console.WriteLine(Heron(a, b, c));
    }
}
