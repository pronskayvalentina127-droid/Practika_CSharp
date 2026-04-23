class Device : IPowerOn, IPowerOff
{
    void IPowerOn.TogglePower()
    {
        Console.WriteLine("Устройство включено");
    }
    void IPowerOff.TogglePower()
    {
        Console.WriteLine("Устройство выключено");
    }
}