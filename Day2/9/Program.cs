using System.Text;

StringBuilder sb = new StringBuilder("Hello world");
string prefix = "Hello";

Console.WriteLine("StringBuilder: " + sb);
Console.WriteLine("Префикс: " + prefix);

bool startsWith = true;

if (sb.Length < prefix.Length)
{
    startsWith = false;
}
else
{
    for (int i = 0; i < prefix.Length; i++)
    {
        if (sb[i] != prefix[i])
        {
            startsWith = false;
            break;
        }
    }
}

if (startsWith)
{
    Console.WriteLine("StringBuilder начинается с \"" + prefix + "\"");
}
else
{
    Console.WriteLine("StringBuilder не начинается с \"" + prefix + "\"");
}