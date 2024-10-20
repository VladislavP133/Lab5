using System;

public class DepositAccount : BankAccount
{
    public override void Новий_рахунок()
    {
        Console.WriteLine("Створено новий депозитний рахунок!");
    }

    public override void Видалити_рахунок()
    {
        Console.WriteLine("Депозитний рахунок видалено!");
    }
}
