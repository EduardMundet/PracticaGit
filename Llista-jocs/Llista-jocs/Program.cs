using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Llista_jocs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escull un joc:");
            Console.WriteLine("   1. Buscamines el joc");
            switch (Convert.ToInt32( Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("has escollit buscamines (joc)");
                    break;
                default:
                    break;
            }

        }
    }
}
