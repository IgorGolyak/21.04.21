using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V.S
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите число y");
            double y = Convert.ToDouble(Console.ReadLine());
            if (x > 0)
            {
                if (y > 0)
                {
                    Console.WriteLine("1 чэтверт");
                }
                else
                {
                    Console.WriteLine("4 чэтверт");
                }

            }
            else
            {
                if (y > 0)
                {
                    Console.WriteLine("2 чэтверт");
                }
                else
                {
                    Console.WriteLine("3 чэтверт");
                }

            }
            Console.ReadKey();
        }
    }
}
