using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    class Program
    {
        static void Main(string[] args) {

            // Homework EX2, Questions Direct to Code Project.

            /* 
             * Question 1-1
             * 
            
            if (i < 0)
            {
                X = 10
            }

            if (i < 0) {
                x = 10;
            } else {
                x = 10;
            }

            if (i < 0) x = 10; else x = 10;

            if (i > 0 Or i<100) x = 10;

            */


            //1-5
            int fiv = 0;
            //2 + 4 + 6 + 8 + 10
            for (int s = 2; s <= 10; s += 2) {
                fiv += s;
            }
            Console.WriteLine(fiv);



            /*
             * 1-6
             * 
            
            //-5 -3 -1 1 3 5 7 9 11 13 15
            for (int k = -5; k <= 15; k += 2) {
                c += "*" ;
            }

            */



            //2-1
            int x = 5, y = 5;
            while (x < 5) {
                x += 1;
            }
            do {
                y += 1;
            } while (y < 5);
            Console.WriteLine(x);
            Console.WriteLine(y);


            //2-2
            int i;
            string m;
            i = 10;
            if (i > 0) {
                m = "A" ;
            }
            else if (i < 100) {
                m = "B" ;
            }
            else {
                m = "C" ;
            }
            Console.WriteLine(m);

            //3-1
            int nums = 1000;
            for (int ii = -1; ii >= -55; ii-=2)
            {
                nums += ii;
            }
            Console.WriteLine(nums); //should print out 216

            //pause
            Console.ReadKey();
        }
    }

}

