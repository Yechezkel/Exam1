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
        public Tree(Node Root)
        {
            this.Root = Root;
        }
        //public void Insert(Node node) {}

        public string GetTreeString()
        {
            if (Root == null)
                return "Empty tree";
            return Root.GetNodeStringWithoutChild() + GetTreeString(Root.LeftSun) + GetTreeString(Root.RightSun);
        }
        private string GetTreeString(Node node)
        {
            if (node == null)
                return "";
            return "\n" + node.GetNodeStringWithoutChild() + GetTreeString(node.LeftSun) + GetTreeString(node.RightSun);
        }
    }
}
