int[][] jagged = new int[4][];
Random rand = new Random();

for (int i = 0; i < jagged.Length; i++)
{
    jagged[i] = new int[rand.Next(3, 6)];
    for (int j = 0; j < jagged[i].Length; j++)
    {
        jagged[i][j] = rand.Next(1, 10);
    }
}

Console.WriteLine("Исходный ступенчатый массив:");
for (int i = 0; i < jagged.Length; i++)
{
    for (int j = 0; j < jagged[i].Length; j++)
    {
        Console.Write(jagged[i][j] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < jagged.Length; i++)
{
    for (int j = 0; j < jagged[i].Length / 2; j++)
    {
        int temp = jagged[i][j];
        jagged[i][j] = jagged[i][jagged[i].Length - 1 - j];
        jagged[i][jagged[i].Length - 1 - j] = temp;
    }
}

Console.WriteLine("Массив после зеркального отражения:");
for (int i = 0; i < jagged.Length; i++)
{
    for (int j = 0; j < jagged[i].Length; j++)
    {
        Console.Write(jagged[i][j] + " ");
    }
    Console.WriteLine();
}