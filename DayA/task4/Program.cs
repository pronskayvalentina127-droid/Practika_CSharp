using System;
class Program
{
    static void Main()
    {
        int a, b;

        Console.Write("a = ");
        a = int.Parse(Console.ReadLine());

        Console.Write("b = ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine(a + " * " + b + " = " + a * b);

        Console.ReadKey();
    }
}

//Написать программу, которая реализует диалог с пользователем:
//запрашивает с клавиатуры два целых числа, и выводит на экран произведение данных чисел: 