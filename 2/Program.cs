using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ребро куба:");
            int x = Convert.ToInt32(Console.ReadLine());
            int S, V;
            FindCub(x, out S, out V);
            Console.WriteLine("S={0:f2}м2,V={1:f2}м3", S, V);
        }
        static void FindCub(int x, out int S, out int V)
        {
            V = x * x * x;
            S = 6 * x * x;
        }
    }
}
