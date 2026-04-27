using System;
class SearchManager<T>
{
    private ISearchable<T> search;
    public SearchManager()
    {
        search = new SimpleSearch<T>();
    }
    public T FindElement(T[] items, Func<T, bool> predicate)
    {
        return search.Find(items, predicate);
    }
    public void DisplaySearchResult(T item)
    {
        if (item != null)
            Console.WriteLine($"Найден: {item}");
        else
            Console.WriteLine("Элемент не найден");
    }
}

//класс-хранилище