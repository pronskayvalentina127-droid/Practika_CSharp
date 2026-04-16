using System;
class Program
{
    static void Main()
    {
        int number, a, b, c, product;

        Console.Write("Введите трехзначное число: ");
        number = int.Parse(Console.ReadLine());

        a = number / 100;       
        b = (number / 10) % 10; 
        c = number % 10;        

        product = a * b * c;

        Console.WriteLine("Произведение цифр = " + product);
        Console.ReadKey();
    }
}

//Написать программу:
//Дано трехзначное число. Найти произведение его цифр.