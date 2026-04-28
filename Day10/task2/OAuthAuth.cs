using System;
class OAuthAuth : IAuthStrategy
{
    public bool Authenticate(string username, string password)
    {
        Console.WriteLine($"Аутентификация через OAuth: {username}");
        // Имитация проверки
        return username == "user" && password == "pass";
    }
}

class JWTAuth : IAuthStrategy
{
    public bool Authenticate(string username, string password)
    {
        Console.WriteLine($"Аутентификация через JWT: {username}");
        // Имитация проверки
        return username == "admin" && password == "admin123";
    }
}

class BasicAuth : IAuthStrategy
{
    public bool Authenticate(string username, string password)
    {
        Console.WriteLine($"Аутентификация через BasicAuth: {username}");
        // Имитация проверки
        return username == "guest" && password == "guest";
    }
}
//конкретные стратегии