using System;
using System.Collections.Generic;

public class Zero : Vehicle
{
    public double BatteryKWh { get; set; }
    public virtual void ChargeBattery() { }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Zero drives");
    }
    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Zero turns");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Zero stops");
    }
}