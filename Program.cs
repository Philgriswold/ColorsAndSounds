using System;
using System.Collections.Generic;

namespace ColorsAndSounds
{
    class Program
    {
        static void Main(string[] args)
        {
            var zero = new Zero();
            var tesla = new Tesla();
            var cessna = new Cessna();
            var ram = new Ram();

            zero.MaximumOccupancy = 5;
            tesla.MaximumOccupancy = 5;
            cessna.MaximumOccupancy = 20;
            ram.MaximumOccupancy = 2;

            zero.MainColor = "black";
            tesla.MainColor = "white";
            cessna.MainColor = "red";
            ram.MainColor = "blue";

            zero.Drive();
            tesla.Drive();
            cessna.Drive();
            ram.Drive();

            zero.Turn();
            tesla.Turn();
            cessna.Turn();
            ram.Turn();

            zero.Stop();
            tesla.Stop();
            cessna.Stop();
            ram.Stop();
        }
    }
}
