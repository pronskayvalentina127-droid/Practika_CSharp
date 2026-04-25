using System;
using System.IO;
class ConfigLoader
{
    public void LoadConfig(string path)
    {
        if (!File.Exists(path))
        {
            throw new FileNotFoundException($"Файл {path} не найден");
        }
    }
}