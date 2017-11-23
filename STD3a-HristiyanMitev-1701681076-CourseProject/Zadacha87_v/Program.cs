using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha87_v
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 8;
            int i1, j1, k;
            for (i1 = 1; i1 <= val; i1++)
            {
                for (j1 = 1; j1 <= val - i1; j1++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");

            }
           
            
        }
    }
}
