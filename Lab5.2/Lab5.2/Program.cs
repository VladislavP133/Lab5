using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
       
        Console.OutputEncoding = Encoding.UTF8;

        TestAccounts();
    }

    static void TestAccounts()
    {
        // Створюємо поточний рахунок
        var currentAccount = new CurrentAccount();
        currentAccount.Новий_рахунок();
        currentAccount.putMoney(6000);
        currentAccount.getMoney(2500);
        currentAccount.putMoney(1000);
        currentAccount.getMoney(4000);
        currentAccount.getMoney(1000);
        currentAccount.Видалити_рахунок();

        // Створюємо депозитний рахунок
        var depositAccount = new DepositAccount();
        depositAccount.Новий_рахунок();
        depositAccount.putMoney(10000);
        depositAccount.getMoney(3000);
        depositAccount.getMoney(2000);
        depositAccount.Видалити_рахунок();
    }
}
