class SavingsAccount : BankAccount, IDebitAccount
{
    public SavingsAccount(string number) : base(number)
    {
    }
}