using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2.5;
            double b = 3.0;
            double c = 1.5;
            double d = 4.0;

          
            double numerator = Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) + Math.Pow(d, 2);
            double denominator = Math.Pow(a + b, 2) + Math.Pow(c + d, 2);

            // Provjera da se izbjegne dijeljenje s nulom
            if (denominator != 0)
            {
                double x = numerator / denominator;
                Console.WriteLine($"Vrijednost izraza je: {x}");
            }
            else
            {
                Console.WriteLine("Greška: Djeljenje s nulom.");
            }
        }
    }
}
