using System;
class Program
{
    // функция для вычисления длины отрезка между двумя точками
    static double Leng(double xA, double yA, double xB, double yB)
    {
        return Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2)); //формула расстояния между двумя точками
    }
    static void Main()
    {
        Console.Write("Введите xA: ");
        double xA = double.Parse(Console.ReadLine());
        Console.Write("Введите yA: ");
        double yA = double.Parse(Console.ReadLine());

        Console.Write("Введите xB: ");
        double xB = double.Parse(Console.ReadLine());
        Console.Write("Введите yB: ");
        double yB = double.Parse(Console.ReadLine());

        Console.Write("Введите xC: ");
        double xC = double.Parse(Console.ReadLine());
        Console.Write("Введите yC: ");
        double yC = double.Parse(Console.ReadLine());

        Console.Write("Введите xD: ");
        double xD = double.Parse(Console.ReadLine());
        Console.Write("Введите yD: ");
        double yD = double.Parse(Console.ReadLine());
        // вычисление длин отрезков
        double AB = Leng(xA, yA, xB, yB);
        double AC = Leng(xA, yA, xC, yC);
        double AD = Leng(xA, yA, xD, yD);

        Console.WriteLine("Длины отрезков:");
        Console.WriteLine("AB = " + AB);
        Console.WriteLine("AC = " + AC);
        Console.WriteLine("AD = " + AD);
        Console.ReadKey();
    }
}

//Вариант 7. Описать функцию Leng(xA, yA, xB, yB) вещественного типа, находящую длину отрезка AB на плоскости по координатам его концов:  
//(xA, yA, xB, yB — вещественные параметры). С помощью этой функции найти длины отрезков AB, AC, AD, если даны координаты точек A, B, C, D.
