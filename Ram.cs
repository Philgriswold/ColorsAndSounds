using System;
using System.Collections.Generic;

public class Ram : Vehicle
{
    public double FuelCapacity { get; set; }
    public virtual void RefuelTank() { }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Ram drives");
    }
    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Ram turns");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Ram stops");
    }
}