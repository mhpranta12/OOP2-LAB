using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, sum,sub,mul,div;
            x = 10;
            y = 5;
            sum = x + y;
            sub = x - y;
            mul = x * y;
            div = x / y;
            Console.WriteLine("Summation " + sum);
            Console.WriteLine("Subtraction " + sub);
            Console.WriteLine("Multiplication " + mul);
            Console.WriteLine("Division " + div);
        }
    }
}
