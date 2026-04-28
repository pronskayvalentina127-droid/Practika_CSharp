using System;
class Waiter : IOrderObserver
{
    private string name;

    public Waiter(string name)
    {
        this.name = name;
    }
    public void Update(string orderStatus)
    {
        if (orderStatus == "Новый заказ")
        {
            Console.WriteLine($"Официант {name}: Новый заказ! Отношу на кухню.");
        }
        else if (orderStatus == "Готов")
        {
            Console.WriteLine($"Официант {name}: Заказ готов! Несу клиенту.");
        }
        else
        {
            Console.WriteLine($"Официант {name}: Статус заказа - {orderStatus}");
        }
    }
}

//подписчик