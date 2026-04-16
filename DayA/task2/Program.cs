using System;
class Program
{
    static void Main()
    {
        int number, a, b, c, result;

        Console.Write("Введите трехзначное число: ");
        number = int.Parse(Console.ReadLine());

        a = number / 100;
        b = (number / 10) % 10;
        c = number % 10;
        result = b * 100 + c * 10 + a;

        Console.Write(result);
        Console.ReadKey();
    }
}

//Дано трехзначное число. В нем зачеркнули первую слева цифру и приписали ее в конце. Найти полученное число.