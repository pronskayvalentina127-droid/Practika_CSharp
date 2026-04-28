using System;
class Program
{
    static void Main()
    {
        AuthenticationService service = new AuthenticationService();

        // Аутентификация через OAuth
        service.SetStrategy(new OAuthAuth());
        bool result = service.Login("user", "pass");
        Console.WriteLine($"Результат: {result}\n");

        // Аутентификация через JWT
        service.SetStrategy(new JWTAuth());
        result = service.Login("admin", "admin123");
        Console.WriteLine($"Результат: {result}\n");

        // Аутентификация через BasicAuth
        service.SetStrategy(new BasicAuth());
        result = service.Login("guest", "guest");
        Console.WriteLine($"Результат: {result}\n");
        Console.ReadKey();
    }
}

/*Задание 2: Реализация паттерна "Стратегия"
Каждая задача включает несколько классов: контекст, интерфейс стратегии и несколько конкретных стратегий.
Аутентификация пользователя
AuthenticationService (контекст).
IAuthStrategy (интерфейс).
OAuthAuth, JWTAuth, BasicAuth (стратегии).*/