using System;
using System.Collections.Generic;
class SimpleSearch<T> : ISearchable<T> //реализация интерфейса
{
    public T Find(IEnumerable<T> items, Func<T, bool> predicate)
    {
        foreach (T item in items)
        {
            if (predicate(item))
                return item;
        }
        throw new Exception("Элемент не найден"); //если ничего не нашли выбрасываем исключение
    }
}

//реализация интерфейса (поиска)
//перебираем все элементы, пока не найдём тот, который подходит под условие.
