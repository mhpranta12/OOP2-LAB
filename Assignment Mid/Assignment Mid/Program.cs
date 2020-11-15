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
            Course c1 = new Course("Computer Fundamentals", "1011", 3);
            Section s1 = new Section("A", 3);
            Section s2 = new Section("B", 3);
            c1.AddSection(s1);
      
            c1.ShowSection();
            c1.showInfo();
            c1.AddSection(s2);
            c1.ShowSection();
            Console.WriteLine();
            Faculty f1 = new Faculty("Fahad Ahmed", "16 - 0923 - 1");
            f1.AddSection(s1);
            f1.ShowSection();
            f1.AddTeachHour(s1);
            f1.showInfo();
            Section s3 = new Section("B",1);
            f1.AddSection(s3);
            f1.AddTeachHour(s3);
            f1.showInfo();
            Console.WriteLine();

            Section s4 = new Section("c", 20);
            f1.AddSection(s4);
            f1.AddTeachHour(s4);
            f1.showInfo();


        }
    }
}
