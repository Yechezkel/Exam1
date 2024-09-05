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
        public Node Root {  get; set; }
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




        public string GetTreeString()
        {
            if (Root == null)
                return "Empty tree";
            return "Root = "+Root.GetNodeStringWithoutChild() + GetTreeString(Root.LeftSun, "Left", 1) + GetTreeString(Root.RightSun,"Right",1);
        }
        private string GetTreeString(Node node ,string side,int tabs)
        {
            if (node == null)
                return "";
            string str = "\n";
            for (int i = 0; i < tabs; i++)
                str += "-";
            return str +side +" = "+ node.GetNodeStringWithoutChild() + GetTreeString(node.LeftSun,"Left", tabs+1) + GetTreeString(node.RightSun,"Right", tabs + 1);
        }
    }
}
