using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class ClassMain1
    {
        public static Student1 Student1 { get; private set; }

        public static void Main()
        {
            ScienceStudent1 Student = new ScienceStudent1 { regno = 12, Name = "vinay" };
            ScienceStudent1 sciencesubject = new ScienceStudent1  { physics = 54, chemistry = 75, maths = 45 };
            CommerceStudent1 Commercessubject = new CommerceStudent1 { economices = 44, accounts = 82, banking = 44 };

            Console.WriteLine(sciencesubject.GetAvgMarks());
            Console.WriteLine(Commercessubject.GetAvgMarks());
        }
    }
}
