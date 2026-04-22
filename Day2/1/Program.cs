int[] numbers = { 4, 7, 9, 12, 15, 18, 20, 21, 25 };

Console.WriteLine("Массив: " + string.Join(" ", numbers));

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 3 == 0)
    {
        sum = sum + numbers[i];
    }
}

Console.WriteLine("Сумма чисел кратных трем: " + sum);