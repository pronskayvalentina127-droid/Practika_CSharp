class AuthenticationService
{
    private IAuthStrategy strategy;
    public void SetStrategy(IAuthStrategy strategy)
    {
        this.strategy = strategy;
    }
    public bool Login(string username, string password)
    {
        if (strategy == null)
        {
            Console.WriteLine("Стратегия не установлена");
            return false;
        }
        return strategy.Authenticate(username, password);
    }
}
//контекст