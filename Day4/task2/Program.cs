using System;
class Program
{
    static void AddRightDigit(int D, ref int K) //входной, взодной и выходной параметр по ссылке через ref
    {
        K = K * 10 + D;
    }
    static void Main()
    {
        Console.Write("Введите число K: ");
        int K = int.Parse(Console.ReadLine());

        Console.Write("Введите первую цифру D1 (0-9): ");
        int D1 = int.Parse(Console.ReadLine());

        Console.Write("Введите вторую цифру D2 (0-9): ");
        int D2 = int.Parse(Console.ReadLine());

        AddRightDigit(D1, ref K); //d1 передаётся по значению K по ссылке 
        Console.WriteLine("После добавления D1: " + K);

        AddRightDigit(D2, ref K);
        Console.WriteLine("После добавления D2: " + K);
        Console.ReadKey();
    }
}

//Задание 2. Методы не возвращающие значения (процедуры). Способы передачи параметров в методы.
//Описать процедуру AddRightDigit(D, K), добавляющую к целому положительному числу K справа цифру D (D — входной параметр целого типа, 
//лежащий в диапазоне 0–9, K — параметр целого типа, являющийся одновременно входным и выходным). 
//С помощью этой процедуры последовательно добавить к данному числу K справа данные цифры D1 и D2, выводя результат каждого добавления.
