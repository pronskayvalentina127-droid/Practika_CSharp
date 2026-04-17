using System;
class Program
{
    static void Main()
    {
        int n, count = 0;

        Console.Write("Введите число n: ");
        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                count++;
            }
        }

        Console.WriteLine("Количество делителей числа " + n + " = " + count);
        Console.ReadKey();
    }
}

//Нахождения количества делителей заданного числа n