using System;
class Program
{
    static void Main()
    {
        double a, b, c, x, y;

        Console.Write("Введите коэффициент a: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Введите коэффициент b: ");
        b = double.Parse(Console.ReadLine());

        Console.Write("Введите коэффициент c: ");
        c = double.Parse(Console.ReadLine());

        x = -b / (2 * a);
        y = a * x * x + b * x + c;

        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);

        Console.ReadKey();
    }
}

//Определить координаты вершины параболы. Коэффициенты a, b, c заданы.