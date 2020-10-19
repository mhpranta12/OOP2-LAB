using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int no1 = 25;
            int no2=39;
            if(no1!=no2)
            {
                Console.WriteLine(no1+"!="+no2);
            }
            if (no2>no1)
            {
                Console.WriteLine(no2 + ">" + no1);
            }
            if(no1<=no2)
            {
                Console.WriteLine(no1 + "<=" + no2);
            }
        }
    }
}
