class Athlete
{
    public string Name;
    public Coach[] Coaches;    // Агрегация
    public Equipment Gear;     // Композиция
    public Team CurrentTeam;   // Ассоциация
    public Athlete(string name, string equipName, Coach[] coaches, Team team)
    {
        Name = name;
        Gear = new Equipment(equipName);
        Coaches = coaches;
        CurrentTeam = team;
    }
    public void Train()
    {
        Console.WriteLine($"{Name} тренируется");
    }
}