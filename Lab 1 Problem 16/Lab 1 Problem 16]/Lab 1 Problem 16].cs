using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Problem_16_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorials of :");
            String x;
            double l = 1;
            x = Console.ReadLine();
            int z =Convert.ToInt32(x);
            for (int i=1; i<=z;i++)
            {
                l = l * i;
            }
            Console.WriteLine(l);
        }
    }
}
