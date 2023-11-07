using System;

class Test
{

   public static int Calc(int z, int h)
    {
        return (937 / z); 
    }
    public static int CalcA(int z, int h)
    {
        return 1023 / Calc(z, h);       
    }
    public static int CalcB(int z, int h)
    {
        return 1023 % Calc(z, h);
    }

    public static void Main()
    {
        string[] str = Console.ReadLine().Split(' ');
        int z = Convert.ToInt32(str[0]);
        int h = Convert.ToInt32(str[1]);

       /* Console.WriteLine(CalcA(z, h)), (CalcB(z, h));*/
        Console.WriteLine($"{CalcA(z, h)} {CalcB(z, h)}");
       /* Console.WriteLine(CalcB(z, h));*/
    }
}
