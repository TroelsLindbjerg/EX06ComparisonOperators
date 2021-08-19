using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //opg.6
            //Man kan lave et , ved int hvis man har flere variabler (tal) til datatypen(int).
            int a = 2, b = 4;
            // ( == ligmed) (<= / >= størrer/mindre eller ligmed) ( != ikke ligmed)
            Console.WriteLine(a == b);//false
            Console.WriteLine(a > b);//false
            Console.WriteLine(a <= b);//true
            Console.WriteLine(a - b > 0);//false
            Console.WriteLine(a + b > 0);//true
            Console.WriteLine(a > 1 - b);//true

        }
    }
}
