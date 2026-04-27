using System;
using System.IO;
class FileWatcher
{
    private FileSystemWatcher watcher;

    public FileWatcher(string path)
    {
        watcher = new FileSystemWatcher(path);
        watcher.Created += OnCreated;
        watcher.EnableRaisingEvents = true;
    }
    private void OnCreated(object sender, FileSystemEventArgs e)
    {
        string extension = Path.GetExtension(e.Name);
        if (extension == ".tmp")
        {
            Console.WriteLine($"Обнаружен временный файл: {e.Name}");
            File.Delete(e.FullPath);
            Console.WriteLine($"Удален: {e.Name}");
        }
        else
        {
            Console.WriteLine($"Создан файл: {e.Name}");
        }
    }
    public void Stop()
    {
        watcher.EnableRaisingEvents = false;
        watcher.Dispose();
        Console.WriteLine("Отслеживание остановлено");
    }
}