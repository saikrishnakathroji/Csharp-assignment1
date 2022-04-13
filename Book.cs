using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    
    
        public struct Book
        {
            int BookId;
            string Title;
            int Price;
            string bookType;
            enum BookType { Magazine, Novel, ReferenceBook, Miscellaneous };
            public void Display()
            {
                Console.WriteLine("The Details Of The Book:BookId={0},Title={1},Price={2},bookType={3}", BookId, Title, Price, bookType);
            }

            public static void Main(string[] args)
            {
                Book b1 = new Book();
                b1.BookId = 1;
                b1.Title = "Think Like A Monk";
                b1.Price = 350;
                b1.bookType = Convert.ToString(BookType.Magazine);
                b1.Display();

            }
        }

    
}
