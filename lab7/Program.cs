﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            calcSum(a, b, c);
            Console.ReadKey();
        }
        static void calcSum(int a, int b, int c)
        {
            int S = a + b + c;
            Console.WriteLine(S);
        }
    }
}