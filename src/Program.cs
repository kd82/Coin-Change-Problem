using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserChange
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, k = 0;
            int a = 0, b = 0, c = 0, d = 0, e = 0;
            Console.Write("Please Enter the Bill Amount");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nPlease Enter the Your Change");
            k = Convert.ToDouble(Console.ReadLine());
            double y = k - x;

            int z = (int)(((decimal)y % 1) * 100);
            int l = (int)Math.Truncate(y);

            while (z > 25 || z == 25)
            {
                z = z - 25;

                b++;

            };

            while (z > 10 || z == 10)
            {
                z = z - 10;

                c++;
            }
            while (z > 5 || z == 5)
            {
                z = z - 5;

                d++;
            }
            while (z > 1 || z == 1)
            {
                z = z - 1;

                e++;
            }
            Console.Write("\nDollars\n" + a + l);
            Console.WriteLine("\nQuarters " + b);
            Console.WriteLine("\nDimes " + c);
            Console.WriteLine("\nNickel " + d);
            Console.WriteLine("\nPennies " + e);
            Console.Read();

        }
    }
}
