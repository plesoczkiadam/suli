﻿using System;
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
            int a , max, min, i;
            a = 7;
            max = 0;
            min = 0;
            int[] t = new int[a];
            for (i = 0; i < a; i++)
            {
                t[i] = Convert.ToInt32(Console.ReadLine());
                max = t[0];
                if (max < t[i])
                {
                    max = t[i];
                }
                min = t[i];
                if (min > t[i])
                {
                    min = t[i];
                }
            }
            Console.WriteLine("{0}° volt a hőingás ");
            Console.ReadLine();
        }
    }
}
