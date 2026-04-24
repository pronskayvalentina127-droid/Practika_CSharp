using System;

// класс для передачи данных
class WeatherEventArgs : EventArgs
{
    public double Temperature;
    public double WindSpeed;
    public WeatherEventArgs(double temp, double wind)
    {
        Temperature = temp;
        WindSpeed = wind;
    }
}
// издатель
class WeatherStation
{
    public event EventHandler<WeatherEventArgs> WeatherChanged;
    public void UpdateWeather(double temp, double wind)
    {
        Console.WriteLine($"Температура: {temp}°C, Ветер: {wind} м/с");
        WeatherChanged?.Invoke(this, new WeatherEventArgs(temp, wind));
    }
}
// подписчик 1
class DisplayPanel
{
    public void Show(object sender, WeatherEventArgs e)
    {
        Console.WriteLine($"DisplayPanel: {e.Temperature}°C, ветер {e.WindSpeed} м/с");
    }
}
// подписчик 2
class WarningSystem
{
    public void Warn(object sender, WeatherEventArgs e)
    {
        if (e.WindSpeed > 15)
            Console.WriteLine($"WarningSystem: ШТОРМ! Ветер {e.WindSpeed} м/с");
        else
            Console.WriteLine($"WarningSystem: Ветер {e.WindSpeed} м/с - норма");
    }
}
// промежуточный класс
class WeatherMonitor
{
    public WeatherMonitor(WeatherStation station, DisplayPanel display, WarningSystem warning)
    {
        station.WeatherChanged += display.Show;
        station.WeatherChanged += warning.Warn;
    }
}
class Program
{
    static void Main()
    {
        WeatherStation station = new WeatherStation();
        DisplayPanel display = new DisplayPanel();
        WarningSystem warning = new WarningSystem();
        WeatherMonitor monitor = new WeatherMonitor(station, display, warning);

        station.UpdateWeather(25, 10);
        station.UpdateWeather(20, 18);
        Console.ReadKey();
    }
}

//Задание 4: Реализация паттерна "Издатель-Подписчик" (EventHandler)
//Требования:
//В каждой задаче должен быть класс-издатель с событиями, основанными на EventHandler.
//Должен быть промежуточный класс, который подписывает подписчиков на события издателя.
//Два подписчика, которые обрабатывают событие.
//7. Оповещение об изменении погодных условий
//Создайте класс WeatherStation с событием WeatherChanged.
//Промежуточный класс WeatherMonitor подписывает DisplayPanel (обновляет данные) и WarningSystem (предупреждает о шторме).
