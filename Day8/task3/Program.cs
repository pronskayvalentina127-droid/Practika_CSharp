using System;
class Program
{
    static void Main()
    {
        // Поиск чисел
        SearchManager<int> intManager = new SearchManager<int>();
        int[] numbers = { 5, 12, 8, 3, 15, 7 };
        int result = intManager.FindElement(numbers, x => x > 10);
        intManager.DisplaySearchResult(result);
        // Поиск строк
        SearchManager<string> stringManager = new SearchManager<string>();
        string[] words = { "яблоко", "банан", "вишня", "груша" };
        string wordResult = stringManager.FindElement(words, s => s == "вишня");
        stringManager.DisplaySearchResult(wordResult);
        Console.ReadKey();
    }
}

/*Задание 3: Работа с обобщениями (Generics) 
В этом задании необходимо использовать обобщения (generics) в C#. Каждая задача должна включать:
Обобщенный интерфейс, определяющий основные методы.
Одну реализацию этого интерфейса, реализующую базовую логику.
Класс-хранилище (репозиторий), который управляет объектами интерфейсного типа.
Класс бизнес-логики, выполняющий простые операции, такие как добавление, удаление, поиск или базовая сортировка.
7. Обобщенный интерфейс поиска данных
Интерфейс ISearchable<T> – описывает поиск элементов.
T Find(IEnumerable<T> items, Func<T, bool> predicate): находит первый элемент по условию.
Класс SimpleSearch<T> – выполняет поиск.
Класс SearchManager<T> – управляет поиском.
void DisplaySearchResult(T item): показывает найденный элемент.*/