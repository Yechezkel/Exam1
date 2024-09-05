using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    public class Treat
    {
        public string ThreatType { get; set; }
        public int Volume { get; set; }
        public int Sophistication { get; set; }
        public string Target { get; set; }
        
        public Treat(string ThreatType, int Volume, int Sophistication, string Target)
        {
            this.ThreatType = ThreatType;
            this.Volume = Volume;
            this.Sophistication = Sophistication;
            this.Target = Target;
        }

        public int GetSeverity()
        {
            int TargetValue = 5;
            if (dict.ContainsKey(ThreatType))
                TargetValue = dict[ThreatType];
            return Volume * Sophistication+ TargetValue;
        }

        public static Dictionary<string, int> dict = new Dictionary<string, int>{{ "Web Server", 10 },{ "Database", 15 },{ "User Credentials", 20 },};

    }
}
