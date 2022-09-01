using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LinqAssignment
    {
        public static void Main()
        {
            ContainsO();
            max_Lenght_Char();
        }
        public static void ContainsO()
        {
            string[] Names = { "John", "Peter", "Jacob", "Harry", "Jackson" };

            var result = Names.Contains("o");


            Console.WriteLine("sequence contains the value 'o'");
            Console.WriteLine(result);
        }
        public static void max_Lenght_Char()
        {
            string[] Names = { "John", "Peter", "Jacob", "Harry", "Jackson" };
            var result = Names.OrderByDescending(x=>x.Length).First();
            
            Console.WriteLine("In the list the Max length Character is  ");
            Console.WriteLine(result);

        }
        //public static void Matching()
        //{
        //    string[] Names = { "believe", "relief", "receipt", "field" };
        //    int[] b = { 7, 6, 7, 5 };
        //    foreach (string Name in names)
        //    //Console.WriteLine($"{Names} -- {names.Lenght");

        //}


    }
}
