string input = "123.45";

Console.WriteLine("Строка: " + input);

bool isDouble = double.TryParse(input, out double result);

if (isDouble)
{
    Console.WriteLine("Строка является корректным числом с плавающей точкой: " + result);
}
else
{
    Console.WriteLine("Строка НЕ является корректным числом с плавающей точкой");
}