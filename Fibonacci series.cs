using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, a = 0, b = 1, c = 0;
            for (i = 0; i <= 10; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a= b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}
