using System;
class Program
{
    static void Main()
    {
        ConfigurationManager manager = new ConfigurationManager();

        try
        {
            manager.LoadConfig("config.txt");
        }
        catch (ConfigurationException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
            Console.WriteLine($"Внутреннее исключение: {ex.InnerException.Message}");
            Console.WriteLine($"Стек вызовов: {ex.StackTrace}");
        }
        Console.ReadKey();
    }
}

//Задание 2: Работа с внутренними исключениями и логированием
//Общие требования:
//В каждой задаче необходимо:
//Создать класс, содержащий метод, в котором вызывается сторонний метод (из другого класса).
//Вызов метода должен приводить к возникновению исключения, которое перехватывается и оборачивается во внутреннее исключение (InnerException).
//Логировать всю информацию о возникшем исключении, включая стек вызовов и данные о внутреннем исключении.
//Продемонстрировать работу с исключениями в Main через try-catch.
//Ошибка при загрузке конфигурационного файла
//Класс ConfigLoader содержит метод LoadConfig(string path), который вызывает FileNotFoundException, если файл не найден.
//Класс ConfigurationManager перехватывает исключение и оборачивает его в ConfigurationException.