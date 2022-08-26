using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestSalaryInfo
    {
        public static void Main()
        {
            SalaryInfo e = new SalaryInfo(22809, "vasu", "Raichur", 584103, 859546, 30838);
            Console.WriteLine($"Employee Net Salary {e.GetNetSalary()}");
            Console.WriteLine($"Employee Net Salary {e.GetEmpGrade()}");

        }
    }
}
