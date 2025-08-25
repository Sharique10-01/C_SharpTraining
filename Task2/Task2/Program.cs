// Task 2 :


using System;

class Customer
{
    public int CustomerID { get; set; }
    public string Name { get; set; }
    public int UnitsConsumed { get; set; }

    public Customer(int customerID, string name, int unitsConsumed)
    {
        CustomerID = customerID;
        Name = name;
        UnitsConsumed = unitsConsumed;
    }


    public void ShowBill()
    {
        int bill = UnitsConsumed * 5;
        Console.WriteLine($"Customer: {Name} (ID: {CustomerID})");
        Console.WriteLine($"Units Consumed: {UnitsConsumed}");
        Console.WriteLine($"Total Bill: ${bill}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Customer ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Units Consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());

       
        Customer customer = new Customer(id, name, units);

        customer.ShowBill();

        Console.ReadKey();
    }
}