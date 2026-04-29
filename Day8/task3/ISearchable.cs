using System;
using System.Collections.Generic;
interface ISearchable<T> // обобщение, тип неизвестен, любой перебираемый набор (массив, список).
{
    T Find(IEnumerable<T> items, Func<T, bool> predicate); //принимает элемент, возвращает true/false
}

//обощенный-класс
