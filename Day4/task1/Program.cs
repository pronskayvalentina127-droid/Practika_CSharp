using System;
class Program
{
    static double Avg(int[] a)
    {
        int s = 0;
        for (int i = 0; i < a.Length; i++) s += a[i];
        return (double)s / a.Length;
    }
    static void Main()
    {
        int[] arr = { 2, 4, 6, 8 };
        Console.WriteLine(Avg(arr));
        Console.ReadKey();
    }
}

//Задание 1. Работа со статическими методами 
//Реализуйте статический метод, который вычисляет среднее значение массива.
