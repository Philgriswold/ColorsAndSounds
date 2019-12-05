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
    public virtual void Turn()
    {
        Console.WriteLine("Wowowowow");
    }
    public virtual void Stop()
    {
        Console.WriteLine("Screeeech");
    }

}