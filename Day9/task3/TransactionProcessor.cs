using System;
using System.Collections.Generic;
class TransactionProcessor
{
    public List<Transaction> FilterByAmount(List<Transaction> transactions, double minAmount)
    {
        List<Transaction> result = new List<Transaction>();

        foreach (Transaction t in transactions)
        {
            if (t.Amount >= minAmount)
            {
                result.Add(t);
            }
        }
        return result;
    }
    public void PrintTransactions(List<Transaction> transactions)
    {
        foreach (Transaction t in transactions)
        {
            Console.WriteLine(t.ToString());
        }
    }
}

//фильтрация