using System;
class Program
{
    static void Main()
    {
        int A, B;

        Console.Write("Введите A: ");
        A = int.Parse(Console.ReadLine());

        Console.Write("Введите B: ");
        B = int.Parse(Console.ReadLine());

        Console.WriteLine("\nЦикл for:");
        for (int i = B; i >= A; i--)
        {
            Console.WriteLine(i + "^3 = " + i * i * i);
        }

        Console.WriteLine("\nЦикл while:");
        int j = B;
        while (j >= A)
        {
            Console.WriteLine(j + "^3 = " + j * j * j);
            j--;
        }

        Console.WriteLine("\nЦикл do...while:");
        int k = B;
        do
        {
            Console.WriteLine(k + "^3 = " + k * k * k);
            k--;
        } while (k >= A);
        Console.ReadKey();
    }
}

//Вывести на экран (задачу решите тремя способами - используя операторы цикла while, do while и for):
//кубы всех целых чисел из диапазона от А до В () в обратном порядке; 