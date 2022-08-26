using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class SalaryInfo
    {
        int EmpNo;
        string  Ename;
        string Address;
        int pin_code;
        int Phone_no;
        int Grass_salary;
        int pf;
        public SalaryInfo(int EmpNo, string Ename, string Address, int pin_code, int Phone_no, int Grass_salary)
        {
            this.EmpNo = EmpNo; this.Ename = Ename; this.Address = Address; this.pin_code = pin_code;
            this.Phone_no = Phone_no; this.Grass_salary = Grass_salary;
        }
        public int GetNetSalary()
        {
            pf = 12 * Grass_salary / 100;
            int netsal = Grass_salary - pf;
            return netsal;
        }
        public char GetEmpGrade()
        {
            if (GetNetSalary() > 10000)
            {
                return 'a';
            }
            else if (GetNetSalary() > 5000)
            {
                return 'B';
            }
            else 
                    return 'C';
        }

    }
}


    
