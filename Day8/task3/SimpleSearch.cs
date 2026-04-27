using System;
using System.Collections.Generic;
class SimpleSearch<T> : ISearchable<T>
{
    public T Find(IEnumerable<T> items, Func<T, bool> predicate)
    {
        foreach (T item in items)
        {
            if (predicate(item))
                return item;
        }
        throw new Exception("Элемент не найден");
    }
}

//реализация интерфейса