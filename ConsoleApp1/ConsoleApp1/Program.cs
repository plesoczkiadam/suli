using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("enaplo.txt", FileMode.Open);
            StreamReader rs = new StreamReader(fs);
            string s = rs.ReadLine();
            while (s != null)
            {
                Console.WriteLine(s);
                s = rs.ReadLine();

            }
            rs.Close();
            fs.Close();
            Console.ReadKey();
        }
    }
}
