using System;
class Television
{
    private int volume = 10;
    public void PowerOn()
    {
        Console.WriteLine("Телевизор ВКЛЮЧЕН");
    }
    public void PowerOff()
    {
        Console.WriteLine("Телевизор ВЫКЛЮЧЕН");
    }
    public void IncreaseVolume()
    {
        volume++;
        Console.WriteLine($"Громкость увеличена: {volume}");
    }
    public void DecreaseVolume()
    {
        volume--;
        Console.WriteLine($"Громкость уменьшена: {volume}");
    }
}