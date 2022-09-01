using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_LINQ
{
    internal class Example1
    {
        public static void Main()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1058); 
            numbers.Add(54115); 
            numbers.Add(354); 
            numbers.Add(4646);


            var numQuery =from num in numbers select num;

            foreach (int num  in numQuery )
            {
                Console.Write("{0}",num);
            }
            Console.ReadLine();

                

        }
    }
}
