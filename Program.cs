using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            bool v;
            v = true;
            for (i = 1; i < 9; i++)
            {
                if (i % 2 == 1)
                {
                    v = true;

                }
                else
                {
                    v = false;
                }
            }
            for (j = 1; j < 9; i++)
            {
                if (v)
                {
                    Console.WriteLine("A");
                }
                else 
                {
                    Console.WriteLine("B");
                }
            }
            v = (v);
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}
