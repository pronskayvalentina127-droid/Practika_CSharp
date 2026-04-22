using System.Text.RegularExpressions;

string text = "Это   строка   с   множественными    пробелами";

Console.WriteLine("Исходная строка: " + text);

string result = Regex.Replace(text, @"\s+", " ");

Console.WriteLine("Результат: " + result);