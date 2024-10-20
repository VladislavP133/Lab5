using System;

public class CurrentAccount : BankAccount
{
    public override void Новий_рахунок()
    {
        Console.WriteLine("Створено новий поточний рахунок!");
    }

    public override void Видалити_рахунок()
    {
        Console.WriteLine("Поточний рахунок видалено!");
    }
}
