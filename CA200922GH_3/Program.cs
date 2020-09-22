using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200922GH_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //  x y 
            //1 1 2 3 5 8 13 21

            //random comment
            int n = 30;
            int x = 1;
            int y = 1;
            Console.Write($"{x} {y} ");
            for (int i = 0; i < n; i++)
            {
                int k = x + y;
                Console.Write($"{k} ");
                x = y;
                y = k;
            }
            Console.ReadKey();
        }
    }
}
