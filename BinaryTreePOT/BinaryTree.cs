using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreePOT
{
    public class BinaryTree
    {
        Node root;

        public Node GetRoot()
        {
            return root;
        }
        public void SetRoot(Node item)
        {
            this.root = item;
        }
        public Node GetLeftNode(Node n)
        {
            return n.left;
        }
        public BinaryTree()
        {
            root = null;
        }
    }
}
