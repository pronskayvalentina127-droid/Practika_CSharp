using System;
// пользовательский делегат
delegate void LoginHandler(string username);
// издатель
class UserLoginManager
{
    public event LoginHandler UserLoggedIn;

    public void Login(string username)
    {
        Console.WriteLine($"Пользователь {username} вошел в систему");
        UserLoggedIn?.Invoke(username);
    }
}
// подписчик 1
class SecuritySystem
{
    public void CheckAccess(string username)
    {
        Console.WriteLine($"SecuritySystem: Доступ разрешен для {username}");
    }
}
// подписчик 2
class NotificationService
{
    public void SendNotification(string username)
    {
        Console.WriteLine($"NotificationService: Уведомление отправлено {username}");
    }
}
class Program
{
    static void Main()
    {
        UserLoginManager manager = new UserLoginManager();
        SecuritySystem security = new SecuritySystem();
        NotificationService notification = new NotificationService();

        manager.UserLoggedIn += security.CheckAccess;
        manager.UserLoggedIn += notification.SendNotification;
        // вызов события
        manager.Login("Валя");
        manager.Login("Алиса");
        Console.ReadKey();
    }
}

//Задание 3: Реализация паттерна "Издатель-Подписчик" (пользовательский делегат)
//Требования:
//Реализовать паттерн "Издатель-Подписчик" с пользовательским делегатом.
//В каждой задаче должен быть класс-издатель с событием, основанным на пользовательском делегате.
//Два класса-подписчика, которые обрабатывают событие.
//7. Уведомление о входе пользователя
//Создайте класс UserLoginManager, который генерирует событие UserLoggedIn.
//Два подписчика: SecuritySystem(проверяет доступ) и NotificationService(отправляет уведомление).

