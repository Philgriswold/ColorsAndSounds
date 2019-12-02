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
}