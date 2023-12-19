using System;
using System.Collections.Generic;
using System.Linq;

class Program1
{
    static void Main(string[] args)
    {
        // Generate a sequence of integers in the range [20, 40)
        IEnumerable<int> oddNums = Enumerable.Range(0, 20).Where(x => x % 2 != 0);

        // Print each odd number in the sequence
        foreach (int n in oddNums)
        {
            Console.WriteLine(n);
        }

        // Read a line from the console to keep the console window open
        Console.ReadLine();
    }
}
