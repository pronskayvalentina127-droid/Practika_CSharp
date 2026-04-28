using System;
using System;
class Chef : IOrderObserver
{
    public void Update(string orderStatus)
    {
        if (orderStatus == "Новый заказ")
        {
            Console.WriteLine("Повар: Приступаю к готовке!");
        }
        else
        {
            Console.WriteLine($"Повар: Статус заказа - {orderStatus}");
        }
    }
}

//подписчик