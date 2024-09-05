using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    //מודל של איום
    public class Treat
    {
        public string ThreatType { get; set; }
        public int Volume { get; set; }
        public int Sophistication { get; set; }
        public string Target { get; set; }

        //O(1) בנאי המחלקה
        public Treat(string ThreatType, int Volume, int Sophistication, string Target)
        {
            this.ThreatType = ThreatType;
            this.Volume = Volume;
            this.Sophistication = Sophistication;
            this.Target = Target;
        }

        //O(1) מחזירה את ערך החומרה של המטרה האיום מכוון
        public int GetSeverity()
        {
            int TargetValue = 5;
            if (dict.ContainsKey(Target))
                TargetValue = dict[Target];
            return Volume * Sophistication+ TargetValue;
        }
        public static Dictionary<string, int> dict = new Dictionary<string, int>{{ "Web Server", 10 },{ "Database", 15 },{ "User Credentials", 20 },};

    }
}
