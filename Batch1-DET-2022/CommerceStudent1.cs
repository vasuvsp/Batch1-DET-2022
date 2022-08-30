using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class CommerceStudent1:Student1
    {
        public int economices { get; set; }
        public int accounts { get; set; }

        public int banking { get; set; }

        public override double GetAvgMarks()
        {
            return (banking + accounts + banking) / 3;
        }
    }
}
