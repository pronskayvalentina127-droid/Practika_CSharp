using System;
using System.Collections.Generic;
interface ISearchable<T>
{
    T Find(IEnumerable<T> items, Func<T, bool> predicate);
}

//обощенный-класс