using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1.Codes
{
    public struct Dato
    {
        public static void dageIAlt()
        {
            Console.WriteLine("Dage tilbage: " + (int)(H1.Slut-H1.Start).TotalDays);
        }
        public static void dageTilbage()
        {
            Console.WriteLine("Dage tilbage: " + (int)(H1.Slut - DateTime.Now).TotalDays);
        }
    }
}
