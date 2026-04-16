using System;
class Program
{
    static void Main()
    {
        double x, z1, z2;

        Console.Write("x = ");
        x = double.Parse(Console.ReadLine());

        z1 = (x * x + 2 * x - 3 + (x + 1) * Math.Sqrt(x * x - 9)) / (x * x - 2 * x - 3 + (x - 1) * Math.Sqrt(x * x - 9));
        z2 = Math.Sqrt((x + 3) / (x - 3));

        Console.WriteLine("z1 = " + z1);
        Console.WriteLine("z2 = " + z2);
        Console.ReadKey();
    }
}

//Напишите программу расчета по двум формулам.
//Предварительно подготовьте тестовые примеры (результат вычисления по первой формуле должен в большинстве вариантов совпадать со второй).