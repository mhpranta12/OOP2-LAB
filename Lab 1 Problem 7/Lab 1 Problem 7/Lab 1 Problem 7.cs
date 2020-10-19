using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
           double width = 5.6;
           double height = 8.5;
           double area,perimeter;
            area = height * width;
            perimeter = 2*(height +width);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
