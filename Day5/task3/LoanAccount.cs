class LoanAccount : BankAccount, ICreditAccount
{
    public LoanAccount(string number) : base(number)
    {
    }
}