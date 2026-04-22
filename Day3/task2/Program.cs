using System;
static class ArrayOperations
{
    public static double Product(double[] arr)
    {
        double result = 1;
        for (int i = 0; i < arr.Length; i++)
            result *= arr[i];
        return result;
    }
}
class Program
{
    static void Main()
    {
        double[] numbers = { 2, 3, 4, 5 };
        Console.WriteLine(ArrayOperations.Product(numbers));
        Console.ReadKey();
    }
}

//Создайте static классы, которые выполняют различные операции с массивами объектов, включая сортировку, фильтрацию, вычисление статистики и генерацию данных.
//Реализовать метод Product, который перемножает все элементы массива double.
