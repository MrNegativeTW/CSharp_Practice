using System;

namespace HW4_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1-1
             */
            int[,] s = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            Console.WriteLine(s.GetUpperBound(1));

            /*
             * 1-2
             */
            int[] a = new int[] {5,4,3,2,1};
            int[] b = new int[] { 5, 4, 3, 2, 1 };
            int[] c = new int[] { 5, 4, 3, 2, 1 };
            int[] d = new int[] { 5, 4, 3, 2, 1 };
            int[] e = new int[] { 5, 4, 3, 2, 1 };
            int[] f = new int[] { 5, 4, 3, 2, 1 };
            //Array.Sort(a, b, c); //Error
            Array.Sort(a, b); //OK



            Console.Write(a[0]);
            Console.ReadKey();
        }
    }
}
