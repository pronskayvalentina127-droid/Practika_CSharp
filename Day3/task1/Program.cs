using System;
class A
{
    public int a, b;

    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public double Method1()
    {
        return 1 / (1 + (a + b) / 2.0);
    }
    public int Method2()
    {
        return (a - b) * (a - b);
    }
}
class Program
{
    static void Main()
    {
        A obj = new A(5, 3);
        Console.WriteLine(obj.Method1());
        Console.WriteLine(obj.Method2());
        Console.ReadKey();
    }
}

//Задание 1.
//Создать класс А с целочисленными полями а и b и двумя методами согласно варианту.
//Внутри класса реализовать конструктор для инициализации a и b.
//Создать объект класса и продемонстрировать работу со всеми элементами класса.
