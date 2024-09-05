using System.Text.Json;
using System.Text.Json.Nodes;

namespace Exam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************* Importing defenceStrategiesBalanced.json And Creating Tree ***********************");
            List<Node> nodes = ReadFromJson<List<Node>>(@"C:\Users\INTERNET\Downloads\defenceStrategiesBalanced.json");
            Tree tree = new Tree();
            foreach (Node node in nodes)
            {
                tree.Insert(node);
            }

            Console.WriteLine("********************* Printing In Order ***********************");
            Console.WriteLine(tree.GetTreeStringInOrder());

            Console.WriteLine("********************* Printing Pre Order **********************");
            Console.WriteLine(tree.GetTreeStringPreOrder());

            Console.WriteLine("********************* Importing threats.json ***********************");

            int i=0; int j=0;   
            //var agents = await ReadFromJsonAsync<List<Agent>>();
        }

        public static T ReadFromJson<T>(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }

    }
}
