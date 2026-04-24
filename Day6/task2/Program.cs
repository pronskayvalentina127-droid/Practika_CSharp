using System;

delegate int[] ArrayProcessor(int[] arr);
class Program
{
    static int[] SortAscending(int[] arr)
    {
        int[] result = (int[])arr.Clone();
        for (int i = 0; i < result.Length - 1; i++)
            for (int j = 0; j < result.Length - i - 1; j++)
                if (result[j] > result[j + 1])
                {
                    int temp = result[j];
                    result[j] = result[j + 1];
                    result[j + 1] = temp;
                }
        return result;
    }
    static int[] SortDescending(int[] arr)
    {
        int[] result = (int[])arr.Clone();
        for (int i = 0; i < result.Length - 1; i++)
            for (int j = 0; j < result.Length - i - 1; j++)
                if (result[j] < result[j + 1])
                {
                    int temp = result[j];
                    result[j] = result[j + 1];
                    result[j + 1] = temp;
                }
        return result;
    }
    static void ProcessArray(int[] arr, ArrayProcessor processor)
    {
        int[] result = processor(arr);
        Console.WriteLine(string.Join(", ", result));
    }
    static void Main()
    {
        int[] numbers = { 5, 2, 8, 1, 9, 3 };

        Console.Write("Исходный массив: ");
        Console.WriteLine(string.Join(", ", numbers));

        Console.Write("По возрастанию: ");
        ProcessArray(numbers, SortAscending);

        Console.Write("По убыванию: ");
        ProcessArray(numbers, SortDescending);
        Console.ReadKey();
    }
}

//Задание 2: Делегаты как параметры методов
//Требования:
//В каждой задаче организовать передачу делегата в качестве параметра метода.
//Использовать два метода в качестве callback (методы обратного вызова).
//7. Делегат для обработки массивов
//Создайте делегат ArrayProcessor, который принимает массив и возвращает обработанный массив.
//Метод ProcessArray должен принимать массив и делегат, который его изменяет.
//Создайте методы SortAscending и SortDescending, передавайте их в ProcessArray.
