using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CSFeature
    {
        public static void Main()
        {
            Action<string> action = (string name) => 
            { 
                Console.WriteLine($"Hii .... {name}"); 
            };
            Action<string,string> action1 = (string s1, string s2) =>
            { 
                Console.WriteLine($"Hii.... {s1}"+$" your from {s2} right....");
            };
            Action<string, string,string > action2 = (string s1, string s2,string s3) =>
            {
                Console.WriteLine($"My name is  {s1}" + $", Native is  {s2} "+$" Presently live in {s3}.");
            };

            action.Invoke("Vasu");
            action1.Invoke("Vasu", "Im in Bengaluru");
            action2.Invoke("vasu", "Raichur", "Bengaluru");

            // lambda syntax
        }
    }
}
