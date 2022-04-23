using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasDarbs3
{
    public class Car
    {
        public string Mark { get; set; }
        public string LicensePlate { get; set; }
        public int Speed { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Mark} can start driving");
        }
        public void SpeedUp()
        {
            Console.WriteLine($"{Mark} can drive 120km/h");
        }
        public void Stop() 
        {
            Console.WriteLine($"{Mark} can stop");   
        }
        public void MakeSound() 
        {
        Console.WriteLine("Beep Beep Beep!");
        }
    }
}