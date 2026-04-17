using System;
class Program
{
    static void Main()
    {
        int number, a, b, c, sum;
        bool result;

        Console.Write("Введите трехзначное число: ");
        number = int.Parse(Console.ReadLine());

        a = number / 100;     
        b = (number / 10) % 10;
        c = number % 10;        

        sum = a + b + c;
        result = (sum % 2 == 0);

        Console.WriteLine("Сумма цифр = " + sum);
        Console.WriteLine("Сумма цифр является четным числом: " + result);
        Console.ReadKey();
    }
}

//Проверить истинность высказывания: "Сумма цифр данного трехзначного числа является четным числом". 
