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
            Library l1 = new Library("21 Boi Mela","Dhaka",100);
            l1.ShowLibInfo();
            l1.AddNewBook(b);
            Book c = new Book("Fera", "Prekkhagriho", "3", "EEE", 20);
            l1.AddNewBook(c);
            
            l1.ShowAllBooks();
            b.AddBookCopy(20);
            b.ShowInfo();
            
            Console.WriteLine();
            l1.DeleteBook(b);
            l1.ShowAllBooks();
        }
    }
}
