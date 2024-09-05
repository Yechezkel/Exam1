using System.Text.Json;
using System.Text.Json.Nodes;

namespace Exam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************* Importing defenceStrategiesBalanced.json And Creating Tree ***********************");
            List<Node> nodes = Service.ReadFromJson<List<Node>>(@"C:\Users\INTERNET\Downloads\defenceStrategiesBalanced.json");
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
            List<Treat> treats = Service.ReadFromJson<List<Treat>>(@"C:\Users\INTERNET\Downloads\threats.json");
            Console.WriteLine(treats.Count + " treats imported");



        }

        

    }
}
