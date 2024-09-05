using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
    //מודל של חוליה בעץ
    public class Node
    {
        public int MinSeverity { get; set; }
        public int MaxSeverity { get; set; }
        public List<string> Defenses { get; set; }
        public Node LeftSun { get; set; }
        public Node RightSun { get; set; }

        //O(1) בנאי המחלקה
        public Node(int MinSeverity, int MaxSeverity, List<string> Defenses)
        {
            this.MinSeverity = MinSeverity;
            this.MaxSeverity = MaxSeverity;
            this.Defenses = Defenses;
            LeftSun = null;
            RightSun = null;
        }

        //O(1) מחזירה את החוליה כמחרוזת של הערכים שלה ללא הבנים
        public string GetNodeStringWithoutChild()
        {
            string result = $"Range: [{MinSeverity},{MaxSeverity}]' Defenses:";
            if (Defenses == null || Defenses.Count == 0)
                result += " empty";
            foreach (string s in Defenses)
                result += ", " + s;
            result += ";";
            return result;
        }

    }
}
