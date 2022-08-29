using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Ageexception
    {
        public static void Main()
        {
            int age;

            try
            {
                Console.WriteLine("Enter the Age:");
                age = int.Parse(Console.ReadLine());

                if (age < 0 || age > 120)
                    throw new InvalidAgeException("Entered Age looks suspicious...Write the real age");

                else
                {
                    Console.WriteLine("Your age is normal");
                }

            }
            catch (InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            { }
        }
    }
}
