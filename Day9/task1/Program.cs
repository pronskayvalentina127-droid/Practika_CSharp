using System;
using System.IO;

class Program
{
    static void Main()
    {
        string fileName = "pronskaya.va";
        string copyFile = "pronskaya_copy.va";
        string movedFile = "pronskaya_moved.va";
        string newName = "pronskaya.io";
        string directory = ".";

        FileManager fm = new FileManager();
        FileInfoProvider info = new FileInfoProvider();

        Console.WriteLine("1. Создание файла и запись текста: ");
        fm.CreateFile(fileName, "Текст для файла Пронской В.А.");
        fm.ReadAndPrint(fileName);

        Console.WriteLine("2. Проверка существования файла перед удалением: ");
        if (fm.FileExists(fileName))
            Console.WriteLine("Файл существует");
        else
            Console.WriteLine("Файл не существует");

        Console.WriteLine("3. Информация о файле: ");
        info.ShowInfo(fileName);

        Console.WriteLine("4. Копирование файла: ");
        fm.CopyFile(fileName, copyFile);
        Console.WriteLine($"Копия создана: {copyFile}");

        Console.WriteLine("5. Перемещение файла: ");
        fm.MoveFile(copyFile, movedFile);
        Console.WriteLine($"Файл перемещен в {movedFile}");

        Console.WriteLine("6. Переименование файла: ");
        fm.RenameFile(fileName, newName);
        Console.WriteLine($"Файл переименован в {newName}");

        Console.WriteLine("7. Ошибка при удалении несуществующего файла: ");
        fm.DeleteFileSafe("not_exist.va");

        Console.WriteLine("8. Сравнение двух файлов по размеру: ");
        info.CompareSize(newName, movedFile);

        Console.WriteLine("9. Удаление всех .va файлов: ");
        fm.DeleteFilesByExtension(directory, ".va");

        Console.WriteLine("10. Список всех файлов в директории: ");
        fm.ListFiles(directory);

        Console.WriteLine("11. Запрет записи в файл: ");
        string testFile = "test.va";
        fm.CreateFile(testFile, "Тестовый текст");
        fm.MakeReadOnly(testFile);
        fm.TryWriteToFile(testFile, "Новый текст");

        Console.WriteLine("12. Проверка прав доступа к файлу: ");
        info.CheckPermissions(testFile);

        Console.ReadKey();
    }
}

/*Задание 1: Основные операции с файлами 
Каждая задача включает:
Создание, копирование, удаление и изменение файлов.
Получение информации о файлах (размер, дата создания, дата последнего изменения).
Классы:
FileManager – отвечает за создание, удаление, копирование, перемещение файлов.
FileInfoProvider – получает информацию о файле (размер, дата создания, дата изменения).
Примеры задач:
Создать файл, записать в него текст, прочитать и вывести в консоль.
Проверить существование файла перед его удалением.
Получить информацию о файле (размер, даты).
Скопировать файл и убедиться, что копия существует.
Переместить файл в новую директорию.
Переименовать файл в файл familiya.io
Обработать ошибку при удалении несуществующего файла.
Сравнить два файла по размеру.
Удалить все файлы в папке, соответствующие определенному шаблону. С расширением ii (см. выше)
Вывести список всех файлов в заданной директории.
Запретить запись в файл и попытаться записать в него.
Проверить доступные права к файлу (чтение, запись, выполнение).
*/