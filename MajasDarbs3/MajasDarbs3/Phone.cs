using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasDarbs3
{
    public class Phone
    {
        public string Model { get; set; }
        public int Size { get; set; }
        public int Mark { get; set; }


        public void Call() 
        {
            Console.WriteLine($"{Model} is calling");
        }
        public void SendSMS()
        {
            Console.WriteLine($"{Model} is sending SMS");
        }
    }
}

