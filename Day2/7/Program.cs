string text = "document.pdf";
string suffix = ".pdf";

Console.WriteLine("Строка: " + text);
Console.WriteLine("Суффикс: " + suffix);

if (text.EndsWith(suffix))
{
    Console.WriteLine("Строка заканчивается на \"" + suffix + "\"");
}
else
{
    Console.WriteLine("Строка не заканчивается на \"" + suffix + "\"");
}