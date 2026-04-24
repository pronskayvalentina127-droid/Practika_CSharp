using System;

// Пользовательский делегат (принимает DateTime, возвращает string)
public delegate string TimeHandler(DateTime date);
// форматирует время
class TimeFormatter
{
    public string FormatTime(DateTime date)
    {
        return $"Время: {date:HH:mm:ss}";
    }
}
// форматирует дату
class DateFormatter
{
    public string FormatDate(DateTime date)
    {
        return $"Дата: {date:dd.MM.yyyy}";
    }
}
class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;

        TimeFormatter tf = new TimeFormatter();
        DateFormatter df = new DateFormatter();

        TimeHandler t = tf.FormatTime;
        TimeHandler d = df.FormatDate;

        Console.WriteLine(t(now));
        Console.WriteLine(d(now));
        Console.ReadKey();
    }
}

//Задание 1: Создание собственного делегата
//Требования:
//В каждой задаче необходимо создать пользовательский делегат.
//Должно быть два класса с методами, которые будут обработчиками делегата.
//Необходимо продемонстрировать работу с методами через делегат.
//7.Делегат для работы с временем
//Создайте делегат TimeHandler, который принимает объект DateTime и возвращает строку.
//Создайте классы TimeFormatter и DateFormatter, реализующие разные форматы вывода.
//Передавайте методы в делегат и демонстрируйте их работу.