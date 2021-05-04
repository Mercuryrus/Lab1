using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            double z1, z2;
            Console.Write("Введите параметр а: ");
            double a = double.Parse(Console.ReadLine());
            
            z1 = (Math.Sin((Math.PI / 2.0) + (3 * a))) / (1 - Math.Sin((3 * a) - Math.PI));
            z2 = 1.0 / Math.Tan(((5.0 / 4.0) * Math.PI) + ((3.0 / 2.0) * a));

            Console.WriteLine("z1 = {0} \nz2 = {1}", z1, z2);

            Console.ReadKey();
        }
    }
}