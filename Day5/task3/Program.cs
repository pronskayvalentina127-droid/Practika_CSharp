using System;
class Program
{
    static void Main()
    {
        BankAccount[] accounts = new BankAccount[]
        {
            new SavingsAccount("SA001"),
            new LoanAccount("LA001"),
            new SavingsAccount("SA002"),
            new LoanAccount("LA002")
        };
        Console.WriteLine("Кредитные счета:");
        foreach (var acc in accounts)
        {
            if (acc is ICreditAccount)
            {
                Console.WriteLine(acc.Number);
            }
        }
        Console.ReadKey();
    }
}

//Задание 3: Работа с базовым классом, интерфейсами и наследованием 
//В каждой задаче должно быть:
//Один базовый класс.
//Два интерфейса.
//Два типа наследников, реализующих каждый свой интерфейс.
//Один массив элементов базового класса.
//Бизнес-логика по поиску и фильтрации элементов по типам интерфейсов.
//7. Банковские счета
//Создать базовый класс BankAccount.
//Интерфейс IDebitAccount (для дебетовых счетов).
//Интерфейс ICreditAccount (для кредитных счетов).
//Классы SavingsAccount и LoanAccount, реализующие соответствующие интерфейсы.
//Создать массив счетов и найти все кредитные.