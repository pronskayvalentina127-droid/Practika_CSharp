using System;
class Program
{
    static void Main()
    {
        double A = 0.5, B = 1, x, y, H;
        int M = 10;

        H = (B - A) / M;

        Console.WriteLine("Табулирование функции y = arccos(x)");
        Console.WriteLine("Отрезок: [" + A + ", " + B + "]");
        Console.WriteLine("Количество шагов: M = " + M);
        Console.WriteLine("Шаг: H = " + H);
        Console.WriteLine("\n   x\t\t y");

        x = A;
        for (int i = 0; i <= M; i++)
        {
            y = Math.Acos(x);
            Console.WriteLine("{0:F4}\t\t{1:F4}", x, y);
            x = x + H;
        }
        Console.ReadKey();
    }
}

// Табулирование функций.
//Постановка задачи: Составить программу вычисления значений функции F(x) на отрезке [A, B] в точках xi=x+H, где H=(B-A)/M, M – заданное целое число.
//Пример: Получить 20 значений функции   при изменении аргумента x в диапазоне [0,1; 2,1] с шагом 0,1.
//Блок-схема алгоритма:

//Функция Параметры(А,В) M
//Arccosx     0,5    1   10


