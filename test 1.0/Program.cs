using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon be 2-t számot te");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            int szam2 = Convert.ToInt32(Console.ReadLine());
            if (szam1>szam2)
            {
                Console.WriteLine("Az egyes szám nagyobb");
            }
            else
            {
                Console.WriteLine("Az kettes szám a nagyobb");
            }
            Console.ReadKey();
        }
    }
}
