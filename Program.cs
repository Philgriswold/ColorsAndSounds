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

            zero.MainColor = "black";
            tesla.MainColor = "white";
            cessna.MainColor = "red";
            ram.MainColor = "blue";
        }
    }
}
