using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-1
            //Output: 5
            int k = 5;
            int i=0;
            i = k++;
            Console.WriteLine(i);

            //2-2
            //Output: 100
            Console.WriteLine(25 << 2);

            //2-3
            //Output: True
            Console.WriteLine(Convert.ToBoolean(2));

            //2-6
            //Output: 4
            Console.WriteLine(8 % 3 + 2);

           
            //2-7
            //Output: 6
            Console.WriteLine(3 ^ 5);

            //2-8
            //Output: True
            Console.WriteLine(25 < 10 || 10 > 8);

            //2-8
            //Output: True
            Console.WriteLine(23 > 22 && 11 <= 11);

            // Keep the console window open in debug mode.
            Console.ReadKey();

        }
    }
}
