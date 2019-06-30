using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLibrary;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure round = new Figure(2);

            Figure Triangle = new Figure(3, 4, 6);
            Figure brokenTriangle = new Figure(1000,3,4);
            Figure brokenTriangle1 = new Figure(-2, 3, 4);
            Figure rightAngleTri = new Figure(30, 40, 50);

            Console.Write("\nPress any key to exist.");
            Console.ReadLine();
        }
    }
}
