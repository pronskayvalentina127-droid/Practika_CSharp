using System;
class Program
{
    static void Main()
    {
        ElevatorSystem system = new ElevatorSystem();

        system.AddRequest(3, "Up");
        system.AddRequest(1, "Down");
        system.AddRequest(5, "Up");

        system.ProcessRequests();

        Console.ReadKey();
    }
}

//Задание 1: Работа с недженерик коллекциями
//В каждой задаче необходимо использовать одну из недженерик коллекций (Stack, Queue, Hashtable). Нужно реализовать два класса:
//Модельный класс, содержащий данные сущности.
//Класс-менеджер (или сервис), который будет управлять коллекцией объектов модельного класса и реализовывать бизнес-логику.
//Каждая задача должна включать в себя действия с коллекцией, такие как добавление, удаление, поиск, сортировка, фильтрация и другие операции.
//Симуляция работы лифта (Queue)
//Класс ElevatorRequest с FloorNumber, Direction.
//Класс ElevatorSystem, использующий Queue<ElevatorRequest> для обработки вызовов.