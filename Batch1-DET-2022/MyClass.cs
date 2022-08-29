using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class MyClass
    {
        enum Grade { Pass = 60, Distinction = 85 };
        /// <summary>
        /// method that returns Grade based on the mark
        /// </summary>
        /// <param name="mark">mark as the input</param>
        /// <returns></returns>
        public static string GetGrade(int mark) //IN parameter
        {
            if (mark >= (int)Grade.Distinction)
                return "Distinction";
            else if (mark >= (int)Grade.Pass)
                return "PASS";
            else
                return "FAIL";
        }
        public static void Main()
        {
            Manager m = new Manager(4671, "Karthika", new DateOnly(2005, 5, 10), "techtrng", 10);  //default constructor
            Console.WriteLine(m.Print());

            Manager m1 = new Manager(2345, "Jeeva", new DateOnly(2010, 1, 14), "PEMS", 450);
            Console.WriteLine(m1.Print());

            Emp e1 = new Emp(1, "Jiyana", new DateOnly(2020, 1, 5));
            Console.WriteLine(e1.Print());

        }
    }
}
