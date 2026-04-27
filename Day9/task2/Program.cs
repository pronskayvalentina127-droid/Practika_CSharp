using System;
class Program
{
    static void Main()
    {
        TransactionFileWriter writer = new TransactionFileWriter("file.data");

        writer.AppendTransaction(new Transaction(1, 100.50));
        writer.AppendTransaction(new Transaction(2, 250.00));
        writer.AppendTransaction(new Transaction(3, 75.25));

        writer.ReadAllTransactions();
        Console.ReadKey();
    }
}

/*Описание
В этом задании каждая задача должна реализовывать запись данных в файл file.data.
Должен быть модельный класс, представляющий данные.
Должен быть класс записи, который записывает модельные объекты в файл.
Нельзя использовать сериализацию!
7. Добавление новой записи без удаления старых
Классы:
Transaction – модель (Id, Amount).
TransactionFileWriter – записывает Transaction в file.data.
Методы TransactionFileWriter:
AppendTransaction(Transaction transaction) – добавляет запись без удаления предыдущих данных.*/