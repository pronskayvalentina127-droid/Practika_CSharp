using System;
static class StringExtensions
{
    // метод для string проверяет, содержит ли строка только цифры
    public static bool IsDigitsOnly(this string str) // указывает, что метод расширяет тип string
    {
        if (string.IsNullOrEmpty(str)) return false; //если строка пустая или null

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] < '0' || str[i] > '9') //Если символ не цифра
                return false;
        }
        return true; //все символы цифры
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();
        // Вызов метода
        bool result = input.IsDigitsOnly();
        Console.WriteLine("Строка содержит только цифры: " + result);
        Console.ReadKey();
    }
}

//Задание 4. Работа с расширяющими методами 
//Создайте расширяющий метод для типа string, который проверяет, содержит ли строка только цифры.
