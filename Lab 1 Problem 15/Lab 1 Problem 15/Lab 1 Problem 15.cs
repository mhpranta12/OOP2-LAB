using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Problem_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for(int i=0; i<=5;i++)
            {
                for (int j =0; j <=x; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(i);
                if(x!=5)
                x++;
            }
            //different approach .............
            int x1 = 0;
            for (int i1 = 6; i1 <= 20; i1++)
            {
                for (int j1 =x1; j1 <=6; j1++) // here the loop limit is 6 to merge with the previous style of no.
                {
                    Console.Write(" ");
                }
                Console.WriteLine(i1);
                if (x1!=4)
                    x1--;
            }
        }
    }
}
