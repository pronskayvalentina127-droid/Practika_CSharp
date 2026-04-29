using System;
class Program
{
    static void Main()
    {
        // Получатель
        Television tv = new Television();
        // Команды
        ICommand powerOn = new TVPowerOnCommand(tv);
        ICommand powerOff = new TVPowerOffCommand(tv);
        ICommand volumeUp = new VolumeUpCommand(tv);
        ICommand volumeDown = new VolumeDownCommand(tv);
        // Инициатор (пульт)
        TVRemote remote = new TVRemote();
        // Включаем телевизор
        remote.SetCommand(powerOn);
        remote.PressButton();
        // Увеличиваем громкость
        remote.SetCommand(volumeUp);
        remote.PressButton();
        remote.PressButton();
        // Уменьшаем громкость
        remote.SetCommand(volumeDown);
        remote.PressButton();
        // Выключаем телевизор
        remote.SetCommand(powerOff);
        remote.PressButton();
        Console.ReadKey();
    }
}

/*Задание 3: Реализация паттерна &quot;Команда&quot;
Паттерн &quot;Команда&quot; (Command) инкапсулирует запрос в виде объекта,
позволяя передавать запросы как параметры, ставить их в очередь, отменять
и логировать. В каждом примере будут задействованы следующие
компоненты:
Интерфейс команды (ICommand) с методом Execute().
Конкретная команда (ConcreteCommand), которая реализует
ICommand и инкапсулирует запрос.
Получатель (Receiver), который выполняет конкретное действие.
Инициатор (Invoker), который вызывает команду.
Клиент (Client), который связывает команды с получателями.
Задача 7: Пульт дистанционного управления телевизором
Интерфейс: ICommand с методом Execute().

 Конкретные команды: TVPowerOnCommand, TVPowerOffCommand,
VolumeUpCommand, VolumeDownCommand.
 Получатель: Television с методами PowerOn(), PowerOff(),
IncreaseVolume(), DecreaseVolume().
 Инициатор: TVRemote управляет телевизором через команды.*/