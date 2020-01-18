using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_sharp
{
    static class Printer
    {
        public static void Print(string message, UserColor color)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = (ConsoleColor) color;
            Console.WriteLine(message);
            Console.ForegroundColor = oldColor;
        }
    }
}
