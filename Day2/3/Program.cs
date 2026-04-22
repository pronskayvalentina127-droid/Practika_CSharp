int N;
do
{
    Console.Write("Введите N (N < 10): ");
    N = int.Parse(Console.ReadLine());
}
while (N >= 10);

int a, b;
Console.Write("Введите a: ");
a = int.Parse(Console.ReadLine());
Console.Write("Введите b: ");
b = int.Parse(Console.ReadLine());

int[,] matrix = new int[N, N];
Random rand = new Random();

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        matrix[i, j] = rand.Next(a, b + 1);
    }
}

Console.WriteLine("Исходная матрица:");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

int product = 1;
bool hasOdd = false;

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (matrix[i, j] % 2 != 0)
        {
            product = product * matrix[i, j];
            hasOdd = true;
        }
    }
}

if (hasOdd)
{
    Console.WriteLine("Произведение нечётных элементов: " + product);
}
else
{
    Console.WriteLine("Нечётных элементов нет");
}

int k;
Console.Write("Введите номер строки k: ");
k = int.Parse(Console.ReadLine());

int sum = 0;
for (int j = 0; j < N; j++)
{
    sum = sum + matrix[k, j];
}

Console.WriteLine("Сумма элементов " + k + "-й строки: " + sum);