using System;
class Program
{
    static void Main()
    {
        string path = @"C:\Temp";

        if (!System.IO.Directory.Exists(path))
        {
            System.IO.Directory.CreateDirectory(path);
        }

        Console.WriteLine($"Отслеживание папки: {path}");
        Console.WriteLine("При создании файла .tmp он будет автоматически удален");

        FileWatcher watcher = new FileWatcher(path);

        Console.ReadKey();
        watcher.Stop();
        Console.ReadKey();
    }
}

/*Задание 4: FileSystemWatcher – отслеживание изменений в файлах (сложность 3)
Необходимо реализовать класс, который отслеживает изменения в указанной папке с помощью FileSystemWatcher и выполняет определенные действия.
Каждая задача должна включать:
Класс FileWatcher – основной класс, который использует FileSystemWatcher.
Методы для обработки событий (Created, Deleted, Changed, Renamed).
Дополнительные действия (логирование, копирование, анализ и др.).
7. Автоматическое удаление временных файлов
Если в папке появляется файл с расширением .tmp, он автоматически удаляется.*/