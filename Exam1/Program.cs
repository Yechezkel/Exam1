﻿using System.Text.Json;
using System.Text.Json.Nodes;

namespace Exam1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ייבוא קובץ הג'ייסון של ההגנות
            Console.WriteLine("********************* Importing defenceStrategiesBalanced.json And Creating tree ***********************");
            List<Node> nodes = Service.ReadFromJson<List<Node>>(@"C:\Users\INTERNET\Downloads\defenceStrategiesBalanced.json");
            Tree tree = new Tree();
            foreach (Node node in nodes)
            {
                tree.Insert(node);
            }
            Thread.Sleep(4000);

            // InOrder printing
            Console.WriteLine("\n********************* Printing InOrder ***********************");
            Console.WriteLine(tree.GetTreeStringInOrder());
            Thread.Sleep(4000);

            // PreOrder printing
            Console.WriteLine("\n********************* Printing PreOrder **********************");
            Console.WriteLine(tree.GetTreeStringPreOrder());
            Thread.Sleep(4000);

            // ייבוא קובץ הג'ייסון של ההתקפות
            Console.WriteLine("\n********************* Importing threats.json ***********************");
            List<Treat> treats = Service.ReadFromJson<List<Treat>>(@"C:\Users\INTERNET\Downloads\threats.json");
            Console.WriteLine(treats.Count + " treats imported");

            //ניהול ההתקפות וההגנות
            Console.WriteLine("\n********************* Managing Threats ***********************");
            int i = 1;
            foreach (Treat t in treats)
            {
                Thread.Sleep(4000);
                Console.WriteLine($"Attack number {i}:");
                int severity = t.GetSeverity();
                Node? target = tree.GetNodeBySeverity(severity);
                if (target == null)
                {
                    if (severity < tree.GetMin())
                        Console.WriteLine("Attack is ignored, severity Attack is below the threshold.");
                    else
                        Console.WriteLine("Brace for impact, No suitable defence was found.  ");
                }
                else
                    foreach (string s in target.Defenses)
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine("Executing:" + s);
                    }
                i++;
            }

            //סוף
            Console.WriteLine("\n********************* End ***********************");

        }
    }
}