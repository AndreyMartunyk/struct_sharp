﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook note = new Notebook("bob-toy", "KingLion", 2323.32);
            note.ShowNote();


            Console.ReadKey();
        }
    }
}
