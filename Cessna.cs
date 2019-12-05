using System;
using System.Collections.Generic;

public class Cessna : Vehicle
{
    public double FuelCapacity { get; set; }
    public virtual void RefuelTank() { }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Cessna flies");
    }
    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Cessna turns");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Cessna stops");
    }
}