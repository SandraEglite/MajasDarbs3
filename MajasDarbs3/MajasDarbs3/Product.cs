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

        
        public Product(double A, double B, double C) 
        {
            Size = "Izmērs S";
            if (A + B + C >= 100)
            { Size = "Izmērs M"; }

            Weight = "20kg";
            Creation();
        }
    public void Creation()
        {
            Console.WriteLine("Izveidojam pasūtījumu!");
        }
        public void Demonstration()
        {
            Console.WriteLine($"Jūsu pasūtījums ir gatavs! Prece sver {Weight}. Ievadītie parametri atbilst {Size}");

        }
    }
}
