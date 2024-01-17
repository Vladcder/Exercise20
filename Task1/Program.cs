using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        public delegate double Function(double x);
        static void Main(string[] args)
        {
            Function function= CalculateLength;
            function += CalculateArea;
            function += CalculateVolume;
            Console.Write("Введите радиус: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            var methods = function.GetInvocationList();
            foreach (var method in methods)
            {
                Console.WriteLine(method.DynamicInvoke(radius));
            }
            Console.ReadKey();
        }



        static double CalculateLength(double radius) => 2 * Math.PI * radius;
     

        static double CalculateArea(double radius) => Math.PI * Math.Pow(radius, 2);

        static double CalculateVolume(double radius)=> 4 / 3 * Math.PI * Math.Pow(radius, 3);
    }
}

