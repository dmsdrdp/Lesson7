using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static double GetArea(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треуггольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double Area1 = GetArea(x1, y1, z1);

            Console.WriteLine("Введите стороны второго треуггольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double Area2 = GetArea(x2, y2, z2);

            if (Area1>Area2)
            {
                Console.WriteLine("Площадь первого треугольника больше площади второго");
            }
            else 
            {
                if (Area1 < Area2)
                {
                    Console.WriteLine("Площадь второго треугольника больше площади первого");
                }
                else
                {
                    Console.WriteLine("Площади треугольников равны");
                }
            }
            Console.ReadKey();
        }
    }
}
