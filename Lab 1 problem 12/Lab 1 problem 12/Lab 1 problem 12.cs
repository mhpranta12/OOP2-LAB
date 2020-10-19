using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_problem_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 0;
            for (int x = 0; x < 4; x++)
            {
                if (l % 2 == 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("XO");
                        
                    }
                    Console.WriteLine();
                    l++;
                   
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("OX");
                    }
                    Console.WriteLine();
                    l++;
                }
            }
        }
    }
}
