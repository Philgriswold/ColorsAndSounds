using System;
using System.Collections.Generic;

public class Tesla : Vehicle
{
    public double BatteryKWh { get; set; }
    public virtual void ChargeBattery() { }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} Tesla drives");
    }
    public override void Turn()
    {
        Console.WriteLine($"The {MainColor} Tesla turns");
    }
    public override void Stop()
    {
        Console.WriteLine($"The {MainColor} Tesla stops");
    }
}