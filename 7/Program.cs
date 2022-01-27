using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Три стороны первого треугольника:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            double S1 = FindS(x, y, z);
            Console.WriteLine("S1={0:f2}", S1);
            Console.WriteLine("Три стороны второго треугольника:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int z1 = Convert.ToInt32(Console.ReadLine());
            double S2 = FindS(x1, y1, z1);
            Console.WriteLine("S2={0:f2}", S2);
            if (S1 > S2)
            {
                Console.WriteLine("Площадь первого треугольника больше");
            }
            if (S1 < S2)
            {
                Console.WriteLine("Площадь второго треугольника больше");
            }
            else
                Console.WriteLine("Площади равны");
        }
        static double FindS(int x, int y, int z)
        {

            double p = (x + y + z) / 2;
            double d =
            p * (p - x) * (p - y) * (p - z);
            double S = Math.Sqrt(d);
            return S;
        }
    }
}