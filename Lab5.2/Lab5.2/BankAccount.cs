using System;

public class BankAccount : IAccountManagement
{
    protected int debit = 0;
    protected int credit = 0;
    protected int balance = 0;
    protected int sum = 0;
    protected int result = 0;

    public void putMoney(int sum)
    {
        this.sum = sum;
        if (sum > 0)
        {
            credit += sum;
            balance = credit - debit;
            result = 1;
        }
        else
        {
            result = -1;
        }
        Message();
    }

    public void getMoney(int sum)
    {
        this.sum = sum;
        if (sum <= balance)
        {
            debit += sum;
            balance = credit - debit;
            result = 2;
        }
        else
        {
            result = -2;
        }
        Message();
    }

    public virtual void Новий_рахунок()
    {
        Console.WriteLine("Новий рахунок створено!");
    }

    public virtual void Видалити_рахунок()
    {
        Console.WriteLine("Рахунок видалено!");
    }

    void Message()
    {
        switch (result)
        {
            case 1:
                Console.WriteLine("Операція зарахування грошей пройшла успішно!");
                Console.WriteLine("Сума = {0}, Ваш поточний баланс = {1}", sum, balance);
                break;
            case 2:
                Console.WriteLine("Операція зняття грошей пройшла успішно!");
                Console.WriteLine("Сума = {0}, Ваш поточний баланс = {1}", sum, balance);
                break;
            case -1:
                Console.WriteLine("Операцію зарахування грошей не виконано!");
                Console.WriteLine("Сума має бути більшою за нуль!");
                Console.WriteLine("Сума = {0}, Ваш поточний баланс = {1}", sum, balance);
                break;
            case -2:
                Console.WriteLine("Операцію зняття грошей не виконано!");
                Console.WriteLine("Сума має бути не більшою за баланс!");
                Console.WriteLine("Сума = {0}, Ваш поточний баланс = {1}", sum, balance);
                break;
            default:
                Console.WriteLine("Невідома операція!");
                break;
        }
    }
}
