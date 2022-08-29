using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Batch1_DET_2022
{
    public class CompanyProgram
    {
        public static void Main()
        {
            CompanyManager m = new CompanyManager { Name = "vasu", Surename = "patil", Phone = "8596471253" };
            Company company = new Company { Name = "patil", Address = "Global cityr", Manager = m, Phone = "5654785664", Website = "Sonata-software.com" };
            Console.WriteLine(company.Print());

        }
       

    }
}
