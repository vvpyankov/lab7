using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите длину ребра вашего куба, а мы вычислим его объем и площадь поверхности");
            double a = Convert.ToDouble(Console.ReadLine());
            cubeArVol(a);
            Console.ReadKey();
        }
        static void
            cubeArVol(double a)
        {
            double CubeArea = a * a * 6;
            double CubeVolume = a * a * a;
            Console.WriteLine("Площадь поверхности куба {0:f2}, объем куба {1:f2}", CubeArea, CubeVolume);
        }
    }
}
