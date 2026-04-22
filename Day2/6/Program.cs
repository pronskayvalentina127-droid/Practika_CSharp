string input = "Hello World C# Programming";

Console.WriteLine("Исходная строка: " + input);

char[] chars = input.ToCharArray();

for (int i = 0; i < chars.Length; i++)
{
    if (chars[i] >= 'a' && chars[i] <= 'z')
    {
        chars[i] = (char)(chars[i] - 32);
    }
    else if (chars[i] >= 'A' && chars[i] <= 'Z')
    {
        chars[i] = (char)(chars[i] + 32);
    }
}

string result = new string(chars);

Console.WriteLine("Результат: " + result);