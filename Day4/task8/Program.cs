using System;
class Program
{
    static void GetMinValue(in int a, in int b, out int minValue) //метод для целых чисел
    {
        minValue = a < b ? a : b;
    }
    static void GetMinValue(in double a, in double b, out double minValue) //для вещественных (перегружен)
    {
        minValue = a < b ? a : b;
    }
    static void Main()
    {
        Console.Write("Введите первое целое число: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Введите второе целое число: ");
        int y = int.Parse(Console.ReadLine());

        GetMinValue(in x, in y, out int minInt);
        Console.WriteLine("Минимальное: " + minInt);

        Console.Write("Введите первое вещественное число: ");
        double d1 = double.Parse(Console.ReadLine());
        Console.Write("Введите второе вещественное число: ");
        double d2 = double.Parse(Console.ReadLine());

        GetMinValue(in d1, in d2, out double minDouble);
        Console.WriteLine("Минимальное: " + minDouble);
        Console.ReadKey();
    }
}

//Вариант 7: Возврат минимального значения
//Опишите метод GetMinValue(in int a, in int b, out int minValue), который возвращает минимальное значение из двух целых чисел через out параметр.
//Перегрузите его для GetMinValue(in double a, in double b, out double minValue).
//Пример использования:
//Ввод: GetMinValue(in 5, in 10, out int minInt) должен установить minInt в 5.
//Ввод: GetMinValue(in 2.5, in 1.5, out double minDouble) должен установить minDouble в 1.5.
