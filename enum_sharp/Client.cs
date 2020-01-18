using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_sharp
{
    class Client
    {
        public void Run()
        {
            Console.Write("enter the message: ");
            string message = Console.ReadLine();
            PrintUserColors();
            Console.Write("enter the color: ");
            UserColor color;
            while(!Enum.TryParse<UserColor>(Console.ReadLine().ToLower(), out color))
            {
                PrintUserColors();
                Console.Write("Error input, enter the color:");
            }
            Printer.Print(message, color);
            
        }

        private void PrintUserColors()
        {
            string[] colorNames = Enum.GetNames(typeof(UserColor));
            for (int i = 0; i < colorNames.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, colorNames[i]);
            }
        }
    }
}
