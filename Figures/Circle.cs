using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Circle
    {
        public const double pi = Math.PI;
        int r;

        public double area()
        {
            Console.WriteLine("Enter the radius of the circle: ");
            r = int.Parse(Console.ReadLine());
            return r * r * pi;
        }
        public double primeter()
        {
            Console.WriteLine("Enter the radius of the circle: ");
            r = int.Parse(Console.ReadLine());
            return 2 * r * pi;
        }
    }
}
