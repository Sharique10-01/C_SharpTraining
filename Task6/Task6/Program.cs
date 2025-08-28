using System;

abstract class MeterReading
{
    public int Units { get; set; }
    public abstract int CalculateBill();
}

class ResidentialReading : MeterReading
{
    public ResidentialReading(int units) { Units = units; }
    public override int CalculateBill() => Units * 5;
}

class CommercialReading : MeterReading
{
    public CommercialReading(int units) { Units = units; }
    public override int CalculateBill() => Units * 8;
}

class Program
{
    static void Main()
    {
        MeterReading res = new ResidentialReading(100);
        MeterReading com = new CommercialReading(100);

        Console.WriteLine($"Residential Bill = {res.CalculateBill()}");
        Console.WriteLine($"Commercial Bill = {com.CalculateBill()}");
    }
}
