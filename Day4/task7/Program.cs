using System;
class Program
{
    //метод для стандартной скидки (10%)
    static double GetDiscount(double price)
    {
        return price * 0.9;
    }
    // перегруженный метод для студентов (скидка 20%)
    static double GetDiscount(double price, bool isStudent)
    {
        if (isStudent)
            return price * 0.8;
        else
            return price * 0.9;
    }
    static void Main()
    {
        Console.Write("Введите цену: ");
        double price = double.Parse(Console.ReadLine());
        Console.WriteLine("Стандартная скидка (10%): " + GetDiscount(price));
        Console.WriteLine("Студенческая скидка (20%): " + GetDiscount(price, true));
        Console.ReadKey();
    }
}
//Вариант 7: Расчет скидок
//Опишите метод GetDiscount(double price), который возвращает цену со стандартной скидкой (например, 10%).
//Перегрузите его для GetDiscount(double price, bool isStudent), где для студентов используется большая скидка (например, 20%).
//Пример использования:
// Вызов GetDiscount(100) должен вернуть 90.0.
// Вызов GetDiscount(100, true) должен вернуть 80.0.
