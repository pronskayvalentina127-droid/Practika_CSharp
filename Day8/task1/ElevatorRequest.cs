class ElevatorRequest
{
    public int FloorNumber; // номер этажа
    public string Direction;  // направление
    public ElevatorRequest(int floor, string dir)
    {
        FloorNumber = floor; //сохраняем этаж 
        Direction = dir; //направление
    }
}

//модельный класс
