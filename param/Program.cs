using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace param
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
        static void calcSum(params int[] numbers)
        {
            int S = 0;
            foreach (int n in numbers)
                S += n;
            Console.WriteLine(S);
        }
    }
}
