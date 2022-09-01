using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LearningLinq
    {
        public static void Main()   
        {
            //1. Data Source.
            List<int> numbers = new List<int>();
            numbers.Add(1058 );
            numbers.Add(54115 );
            numbers.Add(354 );
            numbers.Add(4646 );

            //2. Query Creation..Sql Type 

            //Lamda Exp
            //var numQuery = numbers.Select(x => x);


            ////EArly Execution 
            //var numQuery = (from num in numbers select num)
            //    .ToList();

            var numQuery = numbers.Where (x => x>1000);



            numbers.Add(100 );
            numbers.Add(102 );

            //3. Query execution 
            foreach (int num in numQuery)
            {
                Console.Write("{0} ", num);
            }
            Console.ReadLine();

        }
    }    
}
