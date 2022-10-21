using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Q1. 1+2+3+4+....+N<105 請問N是多少
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int i = 1;

            while (i < 105)
                total += i++;
            Console.WriteLine("Sum is: " + total);
        }
    }
}
