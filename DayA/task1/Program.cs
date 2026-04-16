using System;
class Program
{
    static void Main()
    {
        double a, h, S;

        Console.WriteLine("Вычисление площади треугольника.");
        Console.WriteLine("Введите исходные данные:");

        Console.Write("Основание (см): ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Высота (см): ");
        h = double.Parse(Console.ReadLine());

        S = 0.5 * a * h;

        Console.Write("Площадь треугольника (кв.см): {0}", S);

        Console.ReadKey();
    }
}

//7. вычисления площади треугольника, если известна длина основания и высота

//Вычисление площади треугольника.

//Введите исходные данные:
//Основание(см): 8.5
//Высота(см): 10
//Площадь треугольника: 42.50 кв.см.