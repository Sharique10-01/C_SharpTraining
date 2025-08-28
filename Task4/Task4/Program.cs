using System;

class SmartMeter
{
    public int MeterId { get; set; }
    public string CustomerName { get; set; }

    public SmartMeter(int meterId, string customerName)
    {
        MeterId = meterId;
        CustomerName = customerName;
    }
}
class ResidentialMeter : SmartMeter
{
    public string HouseType { get; set; }

    public ResidentialMeter(int meterId, string customerName, string houseType)
        : base(meterId, customerName)
    {
        HouseType = houseType;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Residential Meter -> ID: {MeterId}, Name: {CustomerName}, HouseType: {HouseType}");
    }
}
class CommercialMeter : SmartMeter
{
    public string BusinessType { get; set; }

    public CommercialMeter(int meterId, string customerName, string businessType)
        : base(meterId, customerName)
    {
        BusinessType = businessType;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Commercial Meter -> ID: {MeterId}, Name: {CustomerName}, BusinessType: {BusinessType}");
    }
}

class Program
{
    static void Main()
    {
        ResidentialMeter rMeter = new ResidentialMeter(201, "Alice", "Apartment");
        CommercialMeter cMeter = new CommercialMeter(301, "Bob", "Shop");

    
        rMeter.PrintDetails();
        cMeter.PrintDetails();
    }
}
