using System;
using System.Collections.Generic;
using System.IO;
class TransactionFileReader
{
    private string filePath;

    public TransactionFileReader(string path)
    {
        filePath = path;
    }
    public List<Transaction> ReadTransactions()
    {
        List<Transaction> transactions = new List<Transaction>();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("Файл не существует");
            return transactions;
        }

        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 2)
            {
                int id = int.Parse(parts[0]);
                double amount = double.Parse(parts[1]);
                transactions.Add(new Transaction(id, amount));
            }
        }
        return transactions;
    }
}

//чтение данных