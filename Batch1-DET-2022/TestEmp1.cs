using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestEmp1
    {
        public static void Main()
        {
            Emp1 e = new Emp1(5050, "vasu", new DateOnly(2020, 8, 1));
            Console.WriteLine($"years of experince{e.GetYearsofExp()}");
        }
    }
}
