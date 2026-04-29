using System.Collections;
class ElevatorSystem
{
    private Queue queue = new Queue();
    public void AddRequest(int floor, string dir)
    {
        queue.Enqueue(new ElevatorRequest(floor, dir));
    }
    public void ProcessRequests()
    {
        while (queue.Count > 0)
        {
            ElevatorRequest req = (ElevatorRequest)queue.Dequeue();
            Console.WriteLine($"Этаж: {req.FloorNumber}, {req.Direction}");
        }
    }
}

//менеджер – недженерик Queue
