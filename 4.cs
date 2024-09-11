using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alooooej
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 4, z = 5; // Primjer vrijednosti
            if (x > 0 && y > 0 && z > 0 && (x * x + y * y == z * z))
                Console.WriteLine("Stranice čine pravokutni trokut.");
            else
                Console.WriteLine("Stranice ne čine pravokutni trokut.");
            Console.ReadLine();
        }
    }
}
