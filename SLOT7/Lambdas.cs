﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLOT7
{
    internal class Lambdas
    {
        class Program
        {
            static void Main(string[] args)
            {
                string[] names = { "david", "jane", "peter", "jone", "mark" };

                foreach (string item in names.OrderBy(s => s)) { Console.WriteLine(item); }

            }
        }
    }
}
