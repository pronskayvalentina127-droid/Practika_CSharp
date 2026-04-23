using System;
class Program
{
    static void Main()
    {
        Device device = new Device();

        IPowerOn powerOn = device;
        IPowerOff powerOff = device;

        Console.WriteLine("Через интерфейс IPowerOn:");
        powerOn.TogglePower();

        Console.WriteLine("Через интерфейс IPowerOff:");
        powerOff.TogglePower();
        Console.ReadKey();
    }
}

//Задание 4: Работа с интерфейсами и явной реализацией 
//В каждой задаче должно быть:
//Два интерфейса с одинаковыми методами.
//Один класс, реализующий оба интерфейса, используя явную реализацию.
//Объект класса, доступ к методам интерфейсов только через их ссылки.
//Демонстрация вызова методов через разные ссылки интерфейсов.
//7. Электронные устройства
//Создать интерфейсы IPowerOn и IPowerOff, оба содержат метод void TogglePower();.
//Класс Device реализует оба интерфейса с явной реализацией.
//Вызвать метод TogglePower через оба интерфейса.