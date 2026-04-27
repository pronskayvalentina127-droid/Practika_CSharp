using System;
using System.IO;
class FileManager
{
    public void CreateFile(string path, string content)
    {
        File.WriteAllText(path, content);
        Console.WriteLine($"Файл создан: {path}");
    }
    public void ReadAndPrint(string path)
    {
        if (File.Exists(path))
        {
            string content = File.ReadAllText(path);
            Console.WriteLine($"Содержимое: {content}");
        }
        else
        {
            Console.WriteLine("Файл не найден");
        }
    }
    public bool FileExists(string path)
    {
        return File.Exists(path);
    }
    public void CopyFile(string source, string dest)
    {
        File.Copy(source, dest, true);
    }
    public void MoveFile(string source, string dest)
    {
        if (File.Exists(source))
            File.Move(source, dest);
    }
    public void RenameFile(string oldName, string newName)
    {
        if (File.Exists(oldName))
            File.Move(oldName, newName);
    }
    public void DeleteFileSafe(string path)
    {
        if (File.Exists(path))
        {
            File.Delete(path);
            Console.WriteLine($"Удален: {path}");
        }
        else
        {
            Console.WriteLine($"Ошибка: файл {path} не существует");
        }
    }
    public void DeleteFilesByExtension(string path, string extension)
    {
        if (Directory.Exists(path))
        {
            string[] files = Directory.GetFiles(path, $"*{extension}");
            foreach (string file in files)
            {
                File.Delete(file);
                Console.WriteLine($"Удален: {file}");
            }
        }
    }
    public void ListFiles(string path)
    {
        if (Directory.Exists(path))
        {
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
    public void MakeReadOnly(string path)
    {
        File.SetAttributes(path, FileAttributes.ReadOnly);
        Console.WriteLine($"Файл защищен от записи: {path}");
    }
    public void TryWriteToFile(string path, string content)
    {
        try
        {
            File.WriteAllText(path, content);
            Console.WriteLine("Запись выполнена");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Ошибка: нет прав на запись");
        }
    }
}