using System;
class SearchManager<T>
{
    private ISearchable<T> search; //экземляр класса
    public SearchManager()
    {
        search = new SimpleSearch<T>();
    }
    public T FindElement(T[] items, Func<T, bool> predicate) //метод поиска элементов
    {
        return search.Find(items, predicate); //метод Find из SimpleSearch
    }
    public void DisplaySearchResult(T item) //метод для вывода результатов
    {
        if (item != null)
            Console.WriteLine($"Найден: {item}");
        else
            Console.WriteLine("Элемент не найден");
    }
}

//класс-хранилище
