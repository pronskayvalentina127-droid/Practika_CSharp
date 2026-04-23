using System;
class Program
{
    static bool IsPrime(int n, int i = 2)
    {
        if (n < 2) return false;
        if (i * i > n) return true;
        if (n % i == 0) return false;
        return IsPrime(n, i + 1);
    }
    static void Main()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(n));
        Console.ReadKey();
    }
}

//Задание 3.Работа с методами и рекурсией.
//Напишите метод, который проверяет, является ли число простым, используя рекурсию.
//Метод должен возвращать true, если число простое, и false в противном случае.
//Пример: IsPrime(17) → true.
