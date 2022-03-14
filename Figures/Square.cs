using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Square
    {
        int a, b;

        public double area()
        {
            Console.WriteLine("Enter side A of the square");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B of the square");
            b = int.Parse(Console.ReadLine());
            return a * b;
        }

        public double primeter()
        {
            Console.WriteLine("Enter side A of the square");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side B of the square");
            b = int.Parse(Console.ReadLine());
            return (2 * a) + (2 * b);
        }
    }
}
