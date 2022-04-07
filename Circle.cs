/*5.	Write a single method that calculates the area and circumference of the circle.
 * The area and circumference should be displayed through the client code*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{

    internal class Circle
    {

        static void Main(string[] args)
        {
            double area, perimeter;
            // passing one parameter and getting two returning value
            Circle.circle(5, out area, out perimeter);
            double C_area = Math.Round(area);
            double C_perimeter = Math.Round(perimeter * 1000) / 1000.0;
            Console.WriteLine("Area of Circle is {0}\t", C_area);
            Console.WriteLine("Perimeter of Circle is {0}\t", C_perimeter);
            Console.ReadLine();
        }
        public static void circle(double r, out double area, out double perimeter)
        {
            double PI = 3.1415;
            area = 2 * PI * r;
            perimeter = PI * r * r;
        }
    }
}