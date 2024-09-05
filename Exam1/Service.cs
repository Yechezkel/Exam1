using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Exam1
{
    public class Service
    {
        //O(n) ממירה ג'ייסון לרשימה
        public static T ReadFromJson<T>(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
        
    }
}
