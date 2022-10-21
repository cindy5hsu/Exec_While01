using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        //Q2.使用while,在畫面顯示所有可以整除300的整數，例如:1,2,3,4,5,6,10,...,300
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 300)
            {
                if (300 % i == 0)
                    Console.WriteLine(i + " ");
                i++;
            }

            Console.WriteLine();
        }
    }
}
