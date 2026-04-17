using System;
class Program
{
    static void Main()
    {
        double a, P;

        Console.Write("Введите сторону квадрата: ");
        a = double.Parse(Console.ReadLine());

        P = 4 * a;

        Console.WriteLine("Периметр квадрата = " + P);
        Console.ReadKey();
    }
}

//Дана сторона квадрата. Найти его периметр.
