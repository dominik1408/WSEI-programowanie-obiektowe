using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Triangle
    {
        int a, b, c, h;

        public double area()
        {
            Console.WriteLine("Enter side A of the triangle");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Rnter the height of the triangle");
            h = int.Parse(Console.ReadLine());
            return 0.5 * a * h;
        }

        public double primeter()
        {
            Console.WriteLine("Enter side A of the triangle");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B of the triangle");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side C of the triangle");
            c = int.Parse(Console.ReadLine());
            return a + b + c;
        }
    }
}
