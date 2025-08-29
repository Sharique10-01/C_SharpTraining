using System;
using System.Collections.Generic;

enum MeterStatus { Active, Inactive, Fault }

struct Reading
{
    public DateTime Date;
    public int Units;
    public Reading(DateTime date, int units)
    {
        Date = date;
        Units = units;
    }
}

abstract class Notifier
{
    public abstract void SendMessage(string msg);
}

class SmsNotifier : Notifier
{
    private string phone;
    public SmsNotifier(string phone) { this.phone = phone; }
    public override void SendMessage(string msg) => Console.WriteLine($"SMS to {phone}: {msg}");
}

class EmailNotifier : Notifier
{
    private string email;
    public EmailNotifier(string email) { this.email = email; }
    public override void SendMessage(string msg) => Console.WriteLine($"Email to {email}: {msg}");
}

static class Tariff
{
    public static double RatePerUnit = 5.0;
}

sealed class BillCalculator
{
    public double CalculateBill(int units) => units * Tariff.RatePerUnit;
}

partial class Customer
{
    public string Name { get; set; }
}

partial class Customer
{
    public string? Email { get; set; }
    public string? Phone { get; set; }
}

class Meter
{
    public MeterStatus Status { get; set; }
    public event Action<Reading>? OnReadingAdded;

    public class ReadingHistory
    {
        private List<Reading> readings = new List<Reading>();
        public void Add(Reading r) => readings.Add(r);
        public List<Reading> GetAll() => readings;
    }

    public ReadingHistory History { get; private set; } = new ReadingHistory();

    public void AddReading(Reading r)
    {
        History.Add(r);
        OnReadingAdded?.Invoke(r);
    }
}

class Program
{
    static void Main()
    {
        Customer c1 = new Customer { Name = "Raj", Email = null, Phone = "1234567890" };
        Customer c2 = new Customer { Name = "singh", Email = "raj@mail.com", Phone = null };

        Notifier n1 = (c1.Email ?? "") != "" ? new EmailNotifier(c1.Email!) : new SmsNotifier(c1.Phone!);
        Notifier n2 = (c2.Email ?? "") != "" ? new EmailNotifier(c2.Email!) : new SmsNotifier(c2.Phone!);

        Meter m1 = new Meter { Status = MeterStatus.Active };
        m1.OnReadingAdded += r => n1.SendMessage($"New reading: {r.Units} units on {r.Date}");
        m1.AddReading(new Reading(DateTime.Now, 100));

        Meter m2 = new Meter { Status = MeterStatus.Active };
        m2.OnReadingAdded += r => n2.SendMessage($"New reading: {r.Units} units on {r.Date}");
        m2.AddReading(new Reading(DateTime.Now, 200));

        BillCalculator calc = new BillCalculator();
        Console.WriteLine($"Bill for {c1.Name}: {calc.CalculateBill(100)}");
        Console.WriteLine($"Bill for {c2.Name}: {calc.CalculateBill(200)}");
    }
}
