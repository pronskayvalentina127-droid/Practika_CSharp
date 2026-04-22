int[] a = new int[25];
int[] b = new int[25];
Random rand = new Random();

for (int i = 0; i < 25; i++)
{
    a[i] = rand.Next(-100, 101);
    b[i] = rand.Next(-100, 101);
}

Console.WriteLine("Массив a:");
for (int i = 0; i < 25; i++)
{
    Console.Write(a[i] + " ");
}
Console.WriteLine();

Console.WriteLine("Массив b до преобразования:");
for (int i = 0; i < 25; i++)
{
    Console.Write(b[i] + " ");
}
Console.WriteLine();

for (int i = 0; i < 25; i++)
{
    if (a[i] > b[i])
    {
        b[i] = b[i] * 10;
    }
    else
    {
        b[i] = 0;
    }
}

Console.WriteLine("Массив b после преобразования:");
for (int i = 0; i < 25; i++)
{
    Console.Write(b[i] + " ");
}
Console.WriteLine();

Array.Sort(b);

Console.WriteLine("Массив b отсортированный:");
for (int i = 0; i < 25; i++)
{
    Console.Write(b[i] + " ");
}
Console.WriteLine();

Console.Write("Введите число k для бинарного поиска: ");
int k = int.Parse(Console.ReadLine());

int index = Array.BinarySearch(b, k);

if (index >= 0)
{
    Console.WriteLine("Число " + k + " найдено на позиции " + index);
}
else
{
    Console.WriteLine("Число " + k + " не найдено");
}