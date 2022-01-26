using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Codes
{

    internal class Menu
    {
        public static int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Vælg:");
            Console.WriteLine("1) Søg på fag");
            Console.WriteLine("2) Søg på lærer");
            Console.WriteLine("3) Søg på elev");
            Console.WriteLine("Alt andet) Afslut");
            Console.Write("\r\nVælg 1, 2 eller 3: ");
            Console.WriteLine();
            var choice = Console.ReadKey();
            switch (choice.Key)
            {
                case ConsoleKey.D1:
                    return 1;
                case ConsoleKey.D2:
                    return 2;
                case ConsoleKey.D3:
                    return 3;
                default:
                    return 0;
            }
        }
    }
}
