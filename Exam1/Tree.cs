using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam1
{
    public class Tree
    {
        public Node Root { get; set; }
        public Tree() { }
        //public Tree(Node Root)
        //{
        //    this.Root = Root;
        //}
        public void Insert(Node node)
        {
            if (Root == null)
            {
                Root = node;
                return;
            }
            Node tmp = Root;
            while (true)
            {
                if (node.MaxSeverity < tmp.MaxSeverity)//assuming if (node.MaxSeverity < tmp.MaxSeverity) => (node.MaxSeverity < tmp.MinSeverity)
                {
                    if (tmp.LeftSun == null)
                    {
                        tmp.LeftSun = node;
                        return;
                    }
                    else
                        tmp = tmp.LeftSun;
                }
                else
                {
                    if (tmp.RightSun == null)
                    {
                        tmp.RightSun = node;
                        return;
                    }
                    else
                        tmp = tmp.RightSun;
                }
            }
        }

        public Node? GetNodeBySeverity(int severity)
        {
            return GetNodeBySeverity(Root, severity);
        }
        public Node? GetNodeBySeverity(Node? node,int severity)
        {
            if (node == null)
                return null;
            if (node.MaxSeverity < severity)
                return GetNodeBySeverity( node.RightSun,severity);
            if (node.MinSeverity > severity)
                return GetNodeBySeverity(node.LeftSun, severity);
            return node;
        }





        public string GetTreeStringInOrder()
        {
            if (Root == null)
                return "Empty tree";
            return GetTreeStringInOrder(Root.LeftSun, "Left", 1) + "\nRoot = " + Root.GetNodeStringWithoutChild() + GetTreeStringInOrder(Root.RightSun, "Right", 1);
        }
        private string GetTreeStringInOrder(Node node, string side, int tabs)
        {
            if (node == null)
                return "";
            string str = "\n";
            for (int i = 0; i < tabs; i++)
                str += " --- ";
            return GetTreeStringInOrder(node.LeftSun, "Left", tabs + 1) + str + side + " = " + node.GetNodeStringWithoutChild() + GetTreeStringInOrder(node.RightSun, "Right", tabs + 1);
        }
        public int GetMin()
        {
            if (Root==null)
                return int.MinValue;
            Node temp = Root;
            while (temp.LeftSun != null)
                temp = temp.LeftSun;
            return temp.MinSeverity;
        }


        public string GetTreeStringPreOrder()
        {
            if (Root == null)
                return "Empty tree";
            return "Root = " + Root.GetNodeStringWithoutChild() + GetTreeStringPreOrder(Root.LeftSun, "Left", 1) + GetTreeStringPreOrder(Root.RightSun, "Right", 1);
        }
        private string GetTreeStringPreOrder(Node node, string side, int tabs)
        {
            if (node == null)
                return "";
            string str = "\n";
            for (int i = 0; i < tabs; i++)
                str += " --- " ;
            return str + side + " = " + node.GetNodeStringWithoutChild() + GetTreeStringPreOrder(node.LeftSun, "Left", tabs + 1) + GetTreeStringPreOrder(node.RightSun, "Right", tabs + 1);
        }
    }
}

