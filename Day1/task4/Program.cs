using System;
class Program
{
    static void Main()
    {
        double x, y;

        Console.Write("Введите x: ");
        x = double.Parse(Console.ReadLine());

        if (x >= 4 && x <= 6)
            y = x;
        else
            y = 3 * x + 4 * x * x;

        Console.WriteLine(y);
    }
}

//Написать программу, которая вычисляет значение функции у
