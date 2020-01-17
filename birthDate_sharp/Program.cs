using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birthDate_sharp
{
    public enum TimeComparison
    {
        EarlierThan = -1,
        TheSameAs = 0,
        LaterThan = 1
    }
    class Program
    {
        static void Main(string[] args)
        {
            new Client().Run();

            Console.ReadKey();
        }
    }
}
