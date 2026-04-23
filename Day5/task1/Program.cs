using System;
abstract class LearningMode
{
    public abstract string GetLearningType();
}
class Online : LearningMode
{
    public override string GetLearningType() => "Online - Гибкий график, доступ из любой точки мира, нужен интернет";
}
class Offline : LearningMode
{
    public override string GetLearningType() => "Offline - Очное присутствие, живое общение, расписание в аудиториях";
}
class Hybrid : LearningMode
{
    public override string GetLearningType() => "Hybrid -  Смешанный формат: часть занятий онлайн, часть очно";
}
class Program
{
    static void Main()
    {
        LearningMode[] modes = { new Online(), new Offline(), new Hybrid() };
        foreach (var m in modes)
        Console.WriteLine(m.GetLearningType());
        Console.ReadKey();
    }
}

//Задание 1: Работа с наследованием 
//В каждой задаче:
//Абстрактный базовый класс.
//Три наследника.
//Массив элементов базового класса.
//Бизнес-логика с массивом.
//7. Виды обучения
//Создать абстрактный класс LearningMode с методом GetLearningType(). 
//Создать три типа обучения: Online, Offline, Hybrid.
//Заполнить массив видами обучения и вывести их особенности.