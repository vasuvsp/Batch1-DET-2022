using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Employee_LINQ
    {
       public static void Main()
        {

        }
        public Employee_LINQ(int id, string name, string dept)
        {
            this.ID = id;
            this.Name = name;
            this.Dept = dept;

        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public  static List<Employee_LINQ> GetListofEmployees()
        {
            List<Employee_LINQ> emps = new List<Employee_LINQ>();
            emps.Add(new Employee_LINQ(1, "John", "Training"));
            emps.Add(new Employee_LINQ(2, "Mark", "Finance"));
            emps.Add(new Employee_LINQ(3, "Peter", "Technical"));
            emps.Add(new Employee_LINQ(4, "Bob", "Technical"));
            emps.Add(new Employee_LINQ(5, "Robert", "Finance"));
            emps.Add(new Employee_LINQ(6, "Jason", "Training"));

            return emps;
        }





    }
}