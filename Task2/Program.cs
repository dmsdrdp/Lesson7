using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void GetParamsCube(double a, out double v, out double s)
        {
            s = a * a;
            v = a * a * a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра");
           double a = Convert.ToDouble(Console.ReadLine());
            double v;
            double s;
            GetParamsCube(a, out v, out s);
            Console.WriteLine("Объем = {0}, Площадь поверхности = {1}", v, s);
            Console.ReadKey(); 
        }
    }
}
