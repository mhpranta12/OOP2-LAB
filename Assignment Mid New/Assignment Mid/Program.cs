using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Mid
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d1 = new Department("CSE");

            Course c1 = new Course("Computer Fundamentals", "1011", 5);
            Section s1 = new Section("A");
            c1.AddSection(s1);
            Section s2 = new Section("B");
            c1.AddSection(s2);
            Faculty f1 = new Faculty("Fahad Ahmed", "11-23244-1");
            f1.AddCourse(c1);
            f1.AddSection(s1);
            f1.AddTeachHour(c1, s1);
            f1.AddTeachHour(c1, s2);
            f1.showInfo();
            Console.WriteLine();
            d1.AddCourse(c1);
            d1.ShowCourse();
            Console.WriteLine();
            c1.showInfo();
            c1.ShowSection();

            Console.WriteLine();


            Course c2 = new Course("Advanced Programming with .NET", "3201", 7);
            Section s3 = new Section("A");
           

            Course c3 = new Course("Bangla Literature ", "1101", 20);
            Section s4 = new Section("B");

            Faculty f2 = new Faculty("Tanvir Ahmed", "18-2120210-1");
            f2.AddCourse(c2);
            f2.AddSection(s3);
            f2.AddTeachHour(c2, s3);
            f2.showInfo();
            Console.WriteLine();

            f1.AddCourse(c3);
            f2.AddSection(s4);
            f1.AddTeachHour(c3, s4);
            Console.WriteLine();

            d1.AddCourse(c2);
            d1.ShowCourse();
            Console.WriteLine();






        }
    }
}
