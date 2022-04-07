/*4Q Swapping of two Numbers*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Swap
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first value:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second value:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap first value= " + x + " second value= " + y);
            swapping(ref x,ref y);// calling method
            Console.Write("After swap first value= " + x + " second value= " + y);
        }
        static void swapping(ref int a,ref int b)
        {
            a = a * b;
            b = a / b;
            a = a / b;
        }
    }
}
