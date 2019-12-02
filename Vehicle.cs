using System;
using System.Collections.Generic;

public class Vehicle
{
    public string MainColor { get; set; }
    public int MaximumOccupancy { get; set; }
    public virtual void Drive()
    {
        Console.WriteLine("Vrroooooom");
    }

}