
/*1Q Write a Simple console Application Calculator with the help of Visual Studio .NET IDE
 * which will perform following operations on two numbers:
a.	Addition.
b.	Subtraction.
c.	Multiplication.
d.	Division
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Switchcase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to switch the Calculation");
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Division \n");
            int Cal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first Number: ");
            int input_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            int input_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (Cal)
            {
                case 1:
                    {
                        result = input_1 + input_2;
                        break;
                    }
                case 2:
                    {
                        result = input_1 - input_2;
                        break;
                    }
                case 3:
                    {
                        result = input_1 * input_2;
                        break;
                    }
                case 4:
                    {
                        result = input_1 / input_2;
                        break;
                    }
                default:
                    Console.WriteLine("Wrong entry select the defined number");
                    break;
            }
            Console.WriteLine("The result is {0}", result);
            Console.ReadKey();
        }
    }
}
