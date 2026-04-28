using System;
class Program
{
    static void Main()
    {
        OrderSystem orderSystem = new OrderSystem();

        Customer customer = new Customer("Анна");
        Chef chef = new Chef();
        Waiter waiter = new Waiter("Иван");

        orderSystem.Attach(customer);
        orderSystem.Attach(chef);
        orderSystem.Attach(waiter);

        Console.WriteLine("Новый заказ^ ");
        orderSystem.SetOrderStatus("Новый заказ");

        Console.WriteLine("Статус: Готовится");
        orderSystem.SetOrderStatus("Готовится");

        Console.WriteLine("Статус: Готов ");
        orderSystem.SetOrderStatus("Готов");
        Console.ReadKey();
    }
}

/*Задание 3: Реализация паттерна "Наблюдатель" (Observer)
В каждой задаче должно быть минимум 3 класса:
Издатель (Subject) – хранит список подписчиков и уведомляет их об изменениях.
Интерфейс подписчика (IObserver) – задает метод для получения уведомлений.
Конкретные подписчики (ConcreteObserver) – реализуют логику обработки уведомлений.
7. Контроль заказов в ресторане
 Классы:
OrderSystem – издатель, обновляет статус заказов.
IOrderObserver – интерфейс подписчика.
Customer, Chef, Waiter – подписчики, получают уведомления о статусе заказа.
 Как реализует "Наблюдатель"
Официант и повар узнают о новых заказах сразу после их поступления.*/