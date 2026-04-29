using System.Collections;
class ElevatorSystem
{
    private Queue queue = new Queue(); //создание неджерик очереди (хранит объект)
    public void AddRequest(int floor, string dir)
    {
        queue.Enqueue(new ElevatorRequest(floor, dir)); //Enqueue добавляет элемент в конец очереди
    }
    public void ProcessRequests()
    {
        while (queue.Count > 0)
        {
            ElevatorRequest req = (ElevatorRequest)queue.Dequeue();// Dequeue() извлекает первый элемент очереди и удаляет его
            Console.WriteLine($"Этаж: {req.FloorNumber}, {req.Direction}");
        }
    }
}

//менеджер – недженерик Queue
