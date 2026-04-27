using System;
using System.IO;

class FileInfoProvider
{
    public void ShowInfo(string path)
    {
        if (File.Exists(path))
        {
            FileInfo info = new FileInfo(path);
            Console.WriteLine($"Размер: {info.Length} байт");
            Console.WriteLine($"Создан: {info.CreationTime}");
            Console.WriteLine($"Изменен: {info.LastWriteTime}");
        }
        else
        {
            Console.WriteLine("Файл не найден");
        }
    }
    public void CompareSize(string file1, string file2)
    {
        if (File.Exists(file1) && File.Exists(file2))
        {
            FileInfo f1 = new FileInfo(file1);
            FileInfo f2 = new FileInfo(file2);

            if (f1.Length == f2.Length)
                Console.WriteLine("Файлы одинакового размера");
            else if (f1.Length > f2.Length)
                Console.WriteLine($"{file1} больше {file2}");
            else
                Console.WriteLine($"{file2} больше {file1}");
        }
        else
        {
            Console.WriteLine("Один из файлов не найден");
        }
    }
    public void CheckPermissions(string path)
    {
        if (File.Exists(path))
        {
            FileInfo info = new FileInfo(path);
            bool isReadOnly = (info.Attributes & FileAttributes.ReadOnly) != 0;

            Console.WriteLine($"Чтение: {File.Exists(path)}");
            Console.WriteLine($"Запись: {!isReadOnly}");
            Console.WriteLine($"Выполнение: не применимо");
        }
    }
}