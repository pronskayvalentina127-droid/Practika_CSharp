using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        TransactionFileReader reader = new TransactionFileReader("file.data");
        TransactionProcessor processor = new TransactionProcessor();

        Console.WriteLine("Чтение транзакций из файла: ");
        List<Transaction> allTransactions = reader.ReadTransactions();

        Console.WriteLine($"Загружено транзакций: {allTransactions.Count}");
        processor.PrintTransactions(allTransactions);

        Console.WriteLine("Фильтрация по минимальной сумме 150: ");
        List<Transaction> filtered = processor.FilterByAmount(allTransactions, 150);
        processor.PrintTransactions(filtered);

        Console.WriteLine("Фильтрация по минимальной сумме 50: ");
        filtered = processor.FilterByAmount(allTransactions, 50);
        processor.PrintTransactions(filtered);
        Console.ReadKey();
    }
}

/*Задание 3: Чтение данных из файла "file.data" и их обработка 
В этом задании необходимо реализовать:
Класс для чтения данных из файла file.data (заполненного в Задании 2).
Класс для преобразования данных в коллекцию объектов.
Класс для поиска, фильтрации и сортировки объектов.
Нельзя использовать десериализацию!
7. Фильтрация транзакций по сумме
Классы:
Transaction – модель (Id, Amount).
TransactionFileReader – читает транзакции.
TransactionProcessor – фильтрация.
Методы:
ReadTransactions() – загружает транзакции.
FilterByAmount(decimal minAmount) – фильтрует по минимальной сумме.*/