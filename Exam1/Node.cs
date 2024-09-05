using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class Node
    { 
        public int MinSeverity { get; set; }
        public int MaxSeverity { get; set; }
        public List<string> Defenses { get; set; }
        public Node LeftSun {  get; set; }
        public Node RightSun { get; set; }

        public Node(int MinSeverity, int MaxSeverity, List<string> Defenses)
        {
            this.MinSeverity = MinSeverity;
            this.MaxSeverity = MaxSeverity;
            this.Defenses = Defenses;
            LeftSun =null;
            RightSun = null;
        }
    }


}
