using System;

class SmartMeterAccount
{
    private int balance;

    public void Recharge(int amount)
    {
        balance += amount;
        Console.WriteLine($"Balance after recharge: {balance}");
    }

    public void Consume(int amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Balance after consumption: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }
}

class Program
{
    static void Main()
    {
        SmartMeterAccount account = new SmartMeterAccount();
        account.Recharge(500);
        account.Consume(200);
        account.Consume(400);
    }
}
