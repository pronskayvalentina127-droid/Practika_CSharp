int[,] matrix = new int[4, 5];
Random rand = new Random();

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 5; j++)
    {
        matrix[i, j] = rand.Next(1, 20);
    }
}

Console.WriteLine("Исходная матрица:");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.Write("Введите номер столбца: ");
int col = int.Parse(Console.ReadLine());

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = 0; i < 4; i++)
{
    sum = sum + matrix[i, col];
}

Console.WriteLine("Сумма элементов столбца " + col + ": " + sum);

if (sum % num == 0)
{
    Console.WriteLine("Верно: сумма кратна числу " + num);
}
else
{
    Console.WriteLine("Неверно: сумма не кратна числу " + num);
}