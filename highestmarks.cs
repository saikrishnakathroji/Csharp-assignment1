/*2Q Accept marks of five students, display highest marks obtained*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class highestmarks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks");
            int marks, highest=0;
            for (int i = 1; i <= 5; i++)
            {
                marks = Convert.ToInt32(Console.ReadLine());
                if(marks > highest)
                {
                    highest = marks;
                }
                
            }
            Console.WriteLine("highest marks:" +highest);    
        }
    }
}
