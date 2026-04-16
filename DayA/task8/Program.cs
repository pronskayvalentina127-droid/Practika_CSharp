using System;
class Program
{
    static void Main()
    {
        double x = 2;
        double y;

        double lnExp = Math.Log(Math.Exp(x + 1)); // ln(e^(x+1)) = x+1
        double sqrtVal = Math.Sqrt(lnExp);
        double tgVal = Math.Tan(sqrtVal);

        double sinX2 = Math.Sin(x * x);
        double cosX2 = Math.Cos(x * x);

        y = tgVal - (3 + sinX2) / (sinX2 - cosX2);

        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
        Console.ReadKey();
    }
}