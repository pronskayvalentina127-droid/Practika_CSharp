using System;
class Program
{
    static void Main()
    {
        TemperatureSensor sensor = new TemperatureSensor();

        try
        {
            sensor.SetTemperature(30);
            Console.WriteLine("Температура 30 установлена");

            sensor.SetTemperature(60);
            Console.WriteLine("Температура 60 установлена");
        }
        catch (TemperatureOutOfRangeException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        Console.ReadKey();
    }
}

//Задание 3: Генерация пользовательского исключения с помощью throw при определенных условиях
//Общие требования:
//В каждой задаче необходимо:
//Создать пользовательское исключение (наследник Exception), описывающее конкретную ошибку.
//Реализовать класс, содержащий метод с проверкой входных данных или условий выполнения.
//При несоответствии условиям – выбрасывать пользовательское исключение с помощью throw.
//Обработать исключение в Main через try-catch.
//Проверка допустимого диапазона температур
//Класс TemperatureSensor содержит метод SetTemperature(int temp).
//Если температура выходит за пределы [-50, 50], выбрасывается TemperatureOutOfRangeException.