using System;
using System.IO;
class TransactionFileWriter
{
    private string filePath;

    public TransactionFileWriter(string path)
    {
        filePath = path;
    }
    public void AppendTransaction(Transaction transaction)
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(transaction.ToString());
        }
        Console.WriteLine($"Добавлена транзакция: Id={transaction.Id}, Amount={transaction.Amount}");
    }
    public void ReadAllTransactions()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Файл не существует");
            return;
        }
        Console.WriteLine("Все транзакции: ");
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}

//класс записи