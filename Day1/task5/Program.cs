using System;
class Program
{
    static void Main()
    {
        int number, a, b, c;

        Console.Write("Введите трехзначное число: ");
        number = int.Parse(Console.ReadLine());

        a = number / 100;
        b = (number / 10) % 10;
        c = number % 10;

        if (a == b && b == c)
            Console.WriteLine("Цифры одинаковы");
        else
            Console.WriteLine("Цифры не одинаковы");
        Console.ReadKey();
    }
}

// Написать программу, которая определяет: одинаковы ли цифры данного трехзначного числа.
