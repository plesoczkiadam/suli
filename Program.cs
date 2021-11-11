using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        private const int n =30;
        static int[] a = new int[n];

        static void generalas()
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(-50, 51);
            }
        }
        static void kiir()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void beillesztrendez()
        {
            for (int i = 1; i < n; i++)
            {
                int j = i - 1;
                int x = a[i];
                while ((j > -1) && (x < a[j]))
                {
                    a[j + 1] = a[j];

                }
            }
        }

        static void Main(string[] args)
        {
            generalas();
            kiir();
            beillesztrendez();
            kiir();
            Console.ReadLine();
        }
    }
}
