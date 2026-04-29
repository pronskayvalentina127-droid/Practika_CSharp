using System;
class Program
{
    static void Main()
    {
        // Базовый робот
        IRobot robot = new BasicRobot();
        Console.WriteLine("1. " + robot.GetStatus());
        // Робот + голосовое управление
        IRobot voiceRobot = new VoiceControlDecorator(new BasicRobot());
        Console.WriteLine("2. " + voiceRobot.GetStatus());
        // Робот + голосовое управление + навигация
        IRobot advancedRobot = new NavigationDecorator(
                               new VoiceControlDecorator(
                               new BasicRobot()));
        Console.WriteLine("3. " + advancedRobot.GetStatus());
        // Робот + все функции (голос + навигация + датчики)
        IRobot fullRobot = new SensorDecorator(
                          new NavigationDecorator(
                          new VoiceControlDecorator(
                          new BasicRobot())));
        Console.WriteLine("4. " + fullRobot.GetStatus());
        Console.ReadKey();
    }
}

/*Задание 2: Реализация паттерна &quot;Декоратор&quot;
Паттерн «Декоратор» позволяет динамически добавлять объекту новую
функциональность без изменения его исходного кода. Для реализации этого
паттерна используется базовый интерфейс (или абстрактный класс)
компонента, базовая реализация компонента, а также один или несколько
классов-декораторов, которые оборачивают базовый компонент и расширяют
его поведение. Каждый декоратор реализует тот же интерфейс, что и базовый
класс, и содержит ссылку на объект-компонент. Таким образом, можно
«наслоить» несколько декораторов, комбинируя функциональность.
Задача 7: Робот-помощник с дополнительными функциями
Компонент: IRobot
o Метод: string GetStatus() – возвращает статус робота.
Конкретный компонент: BasicRobot – базовый робот без
дополнительных функций.
Декораторы:
o VoiceControlDecorator – добавляет голосовое управление.
o NavigationDecorator – улучшает навигацию.
o SensorDecorator – добавляет дополнительные датчики.
Взаимодействие: Базовый робот оборачивается в декораторы, которые расширяют его возможности.*/