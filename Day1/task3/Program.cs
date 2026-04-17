using System;
class Program
{
    static void Main()
    {
        int A, B;
        long product = 1;

        Console.Write("Введите A: ");
        A = int.Parse(Console.ReadLine());

        Console.Write("Введите B: ");
        B = int.Parse(Console.ReadLine());

        for (int i = A; i <= B; i++)
        {
            product = product * i;
        }

        Console.WriteLine("Произведение чисел от " + A + " до " + B + " = " + product);
        Console.ReadKey();
    }
}

//Даны два целых числа A и B (A < B). Найти произведение всех целых чисел от A до B включительно. 
//Входные данные: ввести два целых числа A, B (1 <= A, B <= 10).
//Выходные данные: вывести произведение всех целых чисел от A до B включительно.
