using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("Sajid", "samakal", "2", "Rel", 23);
            b.ShowInfo();
            b.AddBookCopy(1);
            b.ShowInfo();
            Console.WriteLine();
            Library l1 = new Library("DU","Dhaka",100);
            l1.ShowInfo();
            l1.AddNewBook(b);
            
            l1.ShowAllBooks();
        }
    }
}
