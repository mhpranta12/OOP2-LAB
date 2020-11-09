using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_Task
{
    class Library 
    {
        private Book[] listofbook;

        private string libName;

    public string LibName
    {
        get { return libName; }
        set { libName = value; }
    }

        private string libAddress;

        public string LibAddress
        {
            get { return libAddress; }
            set { libAddress = value; }
        }
       
       
        int bookcount = 0;
       
        private int totalBook;

        public int TotalBook
        {
            get { return totalBook; }
            set { totalBook = value; }
        }
        virtual public void ShowLibInfo()
        {
            Console.WriteLine("Library Name :" + libName);
            Console.WriteLine("Library Address:" + libAddress);
            Console.WriteLine("Total Book:" + totalBook);
           
        }
        public void ShowAllBooks()
        {
            for (int i=0; i<bookcount;i++)
            {
                listofbook[i].ShowInfo();
            }
        }
        
        
        public void AddNewBook(Book book)
        {
           
                listofbook[bookcount++]=book;
            
        }
        public Library(string libName, string libAddress,int totalBook)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            this.totalBook = totalBook;
            listofbook = new Book[100];
        }
        public Library()
        {
            listofbook = new Book [100];
        }
        public void AddNewBookCopy(Book book, int copy)
        {
           
            for (int i = 0; i < bookcount; i++)
            {
                if (book==listofbook[i])
                {
                    book.AddBookCopy(copy);
                }
            }
        }
        public void DeleteBook(Book book)
        {
           
            for (int i = 0; i <= bookcount; i++)
            {
                if (book == listofbook[i])
                {

                    
                    book =null;
                }
                break;
            }
        }


    }
}
