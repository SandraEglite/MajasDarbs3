using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajasDarbs3
{
    public class Product
    {
        public string Size { get; set; }
     
        public string Weight { get; set; }

      
    public void Creation()
        {
            Console.WriteLine("Izveidojam jūsu pasūtījumu!");
        }
        public void Demonstration()
        {
            Console.WriteLine($"Jūsu pasūtījums ir gatavs! Prece sver {Weight}. Ievadītie parametri atbilst {Size}");

        }
    }
}
