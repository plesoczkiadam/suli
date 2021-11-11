using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //a változók deklarálása
            int a, e, t, sz;
            /*
             "a" a vizsgálandó szám
             "e"-egyesek
             "t"-tizesek
             "sz"-százasok
             */
            Console.WriteLine("Kérek egy 3 jegyű számot!");
            a = Convert.ToInt32(Console.ReadLine());

            //a százasokat úgy kapom meg, hogy a számot elosztom egész osztással 100-zal
            sz = a / 100;
            //Console.WriteLine(sz);

            //a tizeseket úgy, hogy egész-osztással 10-zel, majd maradékosan ismét 10-zel 
            t = (a / 10) % 10;
            //Console.WriteLine(t);

            //az egyeseket úgy, hogy a számot elosztom maradékosan 10-zel
            e = a % 10;
            //Console.WriteLine(e);

            //a feltétel vizsgálata
            //a Math.Pow első paramétere az alap, a második a kitevő
            if (Math.Pow(sz, 3) + Math.Pow(t, 3) + Math.Pow(e, 3) == a)
                Console.WriteLine("A vizsgált szám Armstrong szám");
            else
                Console.WriteLine("A vizsgált szám nem Armstrong szám");
            Console.ReadLine();
        }
    }
}