using System;
class Program
{
    static void Main()
    {
        double x = 2;
        double y;

        double sinX = Math.Sin(x);
        double cosX = Math.Cos(x);

        y = (sinX - cosX) / (sinX + cosX) - (3 + Math.Sin(x * x)) / (sinX * cosX);

        Console.WriteLine("y = " + y);

        Console.ReadKey();
    }
}

//Вычислить значение функции для заданного значения аргумента: