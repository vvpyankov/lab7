using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите стороны 1го треугольника");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double Squar1 = TriangleArea(a, b, c);
            Console.WriteLine("Площадь треугольника {0:f2}", Squar1);
            Console.WriteLine("Введите длины сторон 2го треугольника");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            double Squar2 = TriangleArea(a, b, c);
            Console.WriteLine("Площадь треугольника {0:f2}", Squar2);
            if (Squar1 > Squar2)
                Console.WriteLine("Площадь 1го треугольника больше, {0:f2} > {1:f2}", Squar1, Squar2);
            if (Squar2 > Squar1)
                Console.WriteLine("Площадь 2го треугольника больше, {1:f2} > {0:f2}", Squar1, Squar2);
            if (Squar1 == Squar2)
                Console.WriteLine("Площади треугольников равны, {0:f2} = {1:f2}", Squar1, Squar2);
            Console.ReadKey();
        }
        static double TriangleArea(double a, double b, double c)
        {
            double Perim = a + b + c;
            double p = Perim / 2;
            double Squar = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return Squar;
        }
    }
}
