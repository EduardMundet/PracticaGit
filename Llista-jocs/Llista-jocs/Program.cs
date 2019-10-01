using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Llista_jocs
{
    class Program
    {
        /// <summary>
        /// Comentari del fitxer de jocs
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Escull un joc:");
            Console.WriteLine("   1. Buscamines el joc");
            Console.WriteLine("Escull un joc: \n   1. buscamines");
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
