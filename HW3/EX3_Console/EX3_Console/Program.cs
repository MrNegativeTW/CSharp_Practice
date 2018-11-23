using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3_Console
{
    class Program
    {
        static void Main(string[] args) {
            // 1-1
            int[,] ss = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Console.Write(ss.GetUpperBound(1) + "\n");

            //2-1
            string nameList = "";
            String[] s_name = new string[] {"String1", "String2"};
            foreach (String s in s_name) {
                nameList += s + ",";
            }

            Console.WriteLine(nameList);


            Console.ReadKey();
        }
    }
}
