using System;
abstract class Shape3D
{
    public abstract double CalculateVolume();//без реализации

    public virtual void DisplayInfo()//реализация по умолчанию
    {
        Console.WriteLine("Объем фигуры: " + CalculateVolume());
    }
}
class Sphere : Shape3D
{
    public double Radius;
    public Sphere(double radius)
    {
        Radius = radius;
    }
    public override double CalculateVolume()//реализация абстрактного класса
    {
        return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
    }
    public override void DisplayInfo()// переопределение виртуального метода
    {
        Console.WriteLine("Фигура: Сфера");
        Console.WriteLine("Радиус: " + Radius);
        Console.WriteLine("Объем сферы: " + CalculateVolume());
    }
}
class Cube : Shape3D
{
    public double Side;
    public Cube(double side)
    {
        Side = side;
    }
    public override double CalculateVolume()
    {
        return Math.Pow(Side, 3);
    }
    public override void DisplayInfo()
    {
        Console.WriteLine("Фигура: Куб");
        Console.WriteLine("Сторона: " + Side);
        Console.WriteLine("Объем куба: " + CalculateVolume());
    }
}
class Program
{
    static void Main()
    {
        Sphere sphere = new Sphere(5);//создание объектов
        Cube cube = new Cube(3);
        sphere.DisplayInfo();
        Console.WriteLine();
        cube.DisplayInfo();
        Console.ReadKey();
    }
}

//Задание 5.  Работа с абстрактными классами, виртуальными и абстрактными методами
//Создайте абстрактный класс Shape3D с абстрактным методом CalculateVolume() и виртуальным методом DisplayInfo().
//Реализуйте два класса-наследника: Sphere и Cube.
//В классе Sphere реализуйте метод CalculateVolume() для вычисления объема сферы.
//В классе Cube реализуйте метод CalculateVolume() для вычисления объема куба.
//Переопределите метод DisplayInfo() в обоих классах для вывода информации о трехмерной фигуре.