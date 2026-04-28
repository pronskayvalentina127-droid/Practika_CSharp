interface IAuthStrategy
{
    bool Authenticate(string username, string password);
}
//интерфейс стратегии