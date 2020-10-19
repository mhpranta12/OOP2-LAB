using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Problem_17
{
    class Program
    {
        static void Main(string[] args)
        {

            int l = 0;
            for (int i=0;i<=8;i++)
            {
                for (int j = 0; j <= l; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                if (l >= 5)
                {
                    l--;
                    for (int a = 0; a <= 8; a++)
                    {
                       
                        for (int b = 0; b <= l; b++)
                        {
                            Console.Write("*");
                        }
                        l--;
                        Console.WriteLine();
                    }
                }
                else
                    l++;
            }  
        }
    }
}
