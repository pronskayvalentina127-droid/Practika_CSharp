using System;
class Program
{
    static void Main()
    {
        int A, B, N = 0;

        Console.Write("Введите A: ");
        A = int.Parse(Console.ReadLine());

        Console.Write("Введите B: ");
        B = int.Parse(Console.ReadLine());

        for (int i = B - 1; i > A; i--)
        {
            Console.Write(i + " ");
            N++;
        }

        Console.WriteLine();
        Console.WriteLine("N = " + N);
        Console.ReadKey();
    }
}

//Даны два целых числа A и B (A < B). Вывести в порядке убывания все целые числа, расположенные между A и B (не включая числа A и B), а также количество N этих чисел.
//Входные данные: ввести два целых числа A, B (1 <= A, B <= 100).
//Выходные данные: вывести в порядке убывания все целые числа, расположенные между A и B (не включая числа A и B), а также количество N этих чисел.
