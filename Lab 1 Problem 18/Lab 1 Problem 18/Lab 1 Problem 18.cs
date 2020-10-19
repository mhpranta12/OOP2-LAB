using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Problem_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string p, c, b, m, co;

            Console.WriteLine("Enter Marks of Physics :");
            p=Console.ReadLine();
            double ph=Convert.ToDouble(p);
            Console.WriteLine("Enter Marks of Chemistry :");
            c = Console.ReadLine();
            double ch=Convert.ToDouble(c);
            Console.WriteLine("Enter Marks of Biology :");
            b = Console.ReadLine();
            double bi=Convert.ToDouble(b);
            Console.WriteLine("Enter Marks of Math :");
            m = Console.ReadLine();
            double ma=Convert.ToDouble(m);
            Console.WriteLine("Enter Marks of Computer :");
            co = Console.ReadLine();
            double com=Convert.ToDouble(co);

            if (ph>=90 && ph <=100)
            {
                Console.WriteLine("Grade of Physics : A+");
            }
            else if (ph >=85 && ph<=89)
            {
                Console.WriteLine("Grade of Physics : A");
            }
            else if (ph >= 80 && ph <= 84)
            {
                Console.WriteLine("Grade of Physics : B+");
            }
            else if (ph >= 75 && ph <= 79)
            {
                Console.WriteLine("Grade of Physics : B");
            }
            else if (ph >= 50 && ph <= 74)
            {
                Console.WriteLine("Grade of Physics : C+");
            }
            else if (ph<50)
            {
                Console.WriteLine("Grade of Physics : F");
            }

            // ch 
            if (ch >= 90 && ch <= 100)
            {
                Console.WriteLine("Grade of Chemistry : A+");
            }
            else if (ch >= 85 && ch <= 89)
            {
                Console.WriteLine("Grade of Chemistry : A");
            }
            else if (ch >= 80 && ch <= 84)
            {
                Console.WriteLine("Grade of Chemistry : B+");
            }
            else if (ch >= 75 && ch <= 79)
            {
                Console.WriteLine("Grade of Chemistry : B");
            }
            else if (ch >= 50 && ch <= 74)
            {
                Console.WriteLine("Grade of Chemistry : C+");
            }
            else if (ch < 50)
            {
                Console.WriteLine("Grade of Chemistry : F");
            }

            // math 
            if (ma >= 90 && ma <= 100)
            {
                Console.WriteLine("Grade of Math : A+");
            }
            else if (ma >= 85 && ma <= 89)
            {
                Console.WriteLine("Grade of Math : A");
            }
            else if (ma >= 80 && ma <= 84)
            {
                Console.WriteLine("Grade of Math : B+");
            }
            else if (ma >= 75 && ma <= 79)
            {
                Console.WriteLine("Grade of Math : B");
            }
            else if (ma >= 50 && ma <= 74)
            {
                Console.WriteLine("Grade of Math : C+");
            }
            else if (ma < 50)
            {
                Console.WriteLine("Grade of Math : F");
            }

            //bio

            if (bi >= 90 && bi <= 100)
            {
                Console.WriteLine("Grade of Biology : A+");
            }
            else if (bi >= 85 && bi <= 89)
            {
                Console.WriteLine("Grade of Biology : A");
            }
            else if (bi >= 80 && bi <= 84)
            {
                Console.WriteLine("Grade of Biology : B+");
            }
            else if (bi >= 75 && bi <= 79)
            {
                Console.WriteLine("Grade of Biology : B");
            }
            else if (bi >= 50 && bi <= 74)
            {
                Console.WriteLine("Grade of Biology : C+");
            }
            else if (bi < 50)
            {
                Console.WriteLine("Grade of Biology : F");
            }

            // computer 
            if (com >= 90 && com <= 100)
            {
                Console.WriteLine("Grade of Computer : A+");
            }
            else if (com >= 85 && com <= 89)
            {
                Console.WriteLine("Grade of Computer : A");
            }
            else if (com >= 80 && com <= 84)
            {
                Console.WriteLine("Grade of Computer : B+");
            }
            else if (com >= 75 && com <= 79)
            {
                Console.WriteLine("Grade of Computer : B");
            }
            else if (com >= 50 && com <= 74)
            {
                Console.WriteLine("Grade of Computer : C+");
            }
            else if (com < 50)
            {
                Console.WriteLine("Grade of Computer : F");
            }

            

        }
    }
}
