using System;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            double wynik;
            Circle circle = new Circle();
            Triangle triangle = new Triangle();
            Square square = new Square();

            Console.WriteLine("Chose a figure:");
            Console.WriteLine(" 1 - Circle");
            Console.WriteLine(" 2 - Triangle");
            Console.WriteLine(" 3 - Square");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int operation;
                    Console.WriteLine("What do you want to calculate: ");
                    Console.WriteLine(" 1 - Area");
                    Console.WriteLine(" 2 - Primeter");
                    operation = int.Parse(Console.ReadLine());
                    if (operation == 1)
                    {
                        wynik = circle.area();
                        Console.WriteLine(wynik);
                    }
                    else if (operation == 2)
                    {
                        wynik = circle.primeter();
                        Console.WriteLine(wynik);
                    }
                    else Console.WriteLine("You gave the wrong value");
                    break;

                case 2:
                    Console.WriteLine("What do you want to calculate: ");
                    Console.WriteLine(" 1 - Area");
                    Console.WriteLine(" 2 - Primeter");
                    operation = int.Parse(Console.ReadLine());
                    if (operation == 1)
                    {
                        wynik = triangle.area();
                        Console.WriteLine(wynik);
                    }
                    else if (operation == 2)
                    {
                        wynik = triangle.primeter();
                        Console.WriteLine(wynik);
                    }
                    else Console.WriteLine("You gave the wrong value");
                    break;

                case 3:
                    Console.WriteLine("What do you want to calculate: ");
                    Console.WriteLine(" 1 - Area");
                    Console.WriteLine(" 2 - Primeter");
                    operation = int.Parse(Console.ReadLine());
                    if (operation == 1)
                    {
                        wynik = square.area();
                        Console.WriteLine(wynik);
                    }
                    else if (operation == 2)
                    {
                        wynik = square.primeter();
                        Console.WriteLine(wynik);
                    }
                    else Console.WriteLine("You gave the wrong value");
                    break;

                default:
                    Console.WriteLine("You gave the wrong value");
                    break;
            }
        }
    }
}
