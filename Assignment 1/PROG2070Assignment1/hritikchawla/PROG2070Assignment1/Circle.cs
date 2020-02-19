using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment1
{
    public class Circle
    {
        private int radius;

        //Default constructor that sets radius as 1
        public Circle()
        {
            radius = 1;
        }

        //Non-default constructor that overwrites radius of circle
        public Circle(int r)
        {
            this.radius = r;
        }

        /// <summary>
        /// Gets radius of circle
        /// </summary>
        /// <returns></returns>
        public int GetRadius()
        {
            return radius;
        }

        /// <summary>
        /// Sets radius of circle
        /// </summary>
        /// <param name="r"></param>
        public void SetRadius(int r)
        {
                UP:
                if (radius >= 1)
                {
                    this.radius = r;
                }
                else
                {
                    Console.WriteLine("Please enter a positive integer greater than 0");
                    goto UP;
                }
           
        }

        /// <summary>
        /// returns circumference of circle
        /// </summary>
        /// <returns></returns>
        public double GetCircumference()
        {
            return 2 * Math.PI * radius;
        }

        /// <summary>
        /// Returns area of circle
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public void Menu()
        {
            Console.WriteLine("1.Get Circle Radius");
            Console.WriteLine("2.Change Circle Radius");
            Console.WriteLine("3.Get Circle Circumference");
            Console.WriteLine("4.Get Circle Area");
            Console.WriteLine("5. Exit");
            int option;
            try
            {
                option = int.Parse(Console.ReadLine());
                if(option >= 1 && option<= 5)
                {
                    if(option == 1)
                    {
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("Circle radius is: " + GetRadius());
                        Console.WriteLine("------------------------------------");
                        Menu();
                    }
                    else if(option == 2)
                    {
                        TWO:
                        Console.WriteLine("Please enter radius of circle");
                        try
                        {
                            int rad;
                            rad = int.Parse(Console.ReadLine());
                            if (rad > 0)
                            {
                                SetRadius(rad);
                                Console.WriteLine("------------------------------------");
                                Console.WriteLine("Radius changed");
                                Console.WriteLine("------------------------------------");
                                Menu();
                            }
                            else
                            {
                                Console.WriteLine("Please enter a radius greater than 0");
                                goto TWO;
                            }
                            
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Please enter a valid radius");
                            goto TWO;
                        }
                    }
                    else if(option == 3)
                    {
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("Circumference of circle is: " + GetCircumference());
                        Console.WriteLine("------------------------------------");
                        Menu();
                    }
                    else if(option == 4)
                    {
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("Area of circle is: " + GetArea());
                        Console.WriteLine("------------------------------------");
                        Menu();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Please enter a valid option");
                    Console.WriteLine("------------------------------------");
                    Menu();
                }
            }
            catch
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Please enter a valid option");
                Console.WriteLine("------------------------------------");
                Menu();
            }

        }

        
    }
}
