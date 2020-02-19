using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;
            START:
            Console.WriteLine("Please enter circle radius");

            try
            {
                radius = int.Parse(Console.ReadLine());
                if (radius < 1)
                {
                    Console.WriteLine("Please enter a radius >= 1");
                    goto START;
                }
            }
            catch
            {
                
                Console.WriteLine("Please enter a valid radius");
                goto START;
            }

            Circle circle = new Circle(radius);
            circle.Menu();
        }
    }
}
