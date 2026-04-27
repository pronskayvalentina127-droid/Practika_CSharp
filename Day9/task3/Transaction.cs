class Transaction
{
    public int Id;
    public double Amount;
    public Transaction(int id, double amount)
    {
        Id = id;
        Amount = amount;
    }
    public override string ToString()
    {
        return $"Id={Id}, Amount={Amount}";
    }
}

//модельный класс