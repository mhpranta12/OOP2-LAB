using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x =1,l=5;
            for (int j = 0; j < 5; j++)
            {
                for (int i = x; i <= l; i++)
                {
                    Console.Write(i);




                }
                Console.WriteLine();
                x++;
                l++;
            }
        }
    }
}
