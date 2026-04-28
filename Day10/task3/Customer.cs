using System;
class Customer : IOrderObserver
{
    private string name;

    public Customer(string name)
    {
        this.name = name;
    }
    public void Update(string orderStatus)
    {
        Console.WriteLine($"{name} (Клиент): Статус заказа - {orderStatus}");
    }
}