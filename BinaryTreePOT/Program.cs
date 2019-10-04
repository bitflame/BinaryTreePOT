using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreePOT
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binTree = new BinaryTree();
            Node currNode = new Node(1);
            currNode.left = new Node(2);
            currNode.right = new Node(3);
            binTree.SetRoot(currNode);
            currNode = currNode.left;
            currNode.left = new Node(4);
            currNode.right = new Node(5);
            //PrintPostOrder(binTree.GetRoot());
            //PrintInOrder(binTree.GetRoot());
            PrintPreOrder(binTree.GetRoot());
            Console.ReadLine();//I need this to see the output for InOrder, but I have to remove it
            //when I call PostOrder
        }
        private static void PrintPostOrder(Node r)
        {
            //L, R, root 
            if (r==null)
            {
                return;
            }
            //recure on left
            PrintPostOrder(r.left);
            //recure on right
            PrintPostOrder(r.right);
            //deal with the node itself 
            Console.WriteLine(r.key);
            Console.ReadLine();
        }
        private static void PrintInOrder(Node r)
        {
            //Printing the tree in order
            if (r == null)
            {
                return;
            }
            //L, Root, R
            //Print the left node
            PrintInOrder(r.left);
            Console.ReadLine();
            //Print the node itself
            Console.WriteLine(r.key);
            
            //Print the right node
            PrintInOrder(r.right);
            
        }
        private static void PrintPreOrder(Node r)
        {
            if (r == null)
            {
                return;
            }
            //root, L, R
            //print the node first
            Console.WriteLine(r.key);
            PrintPreOrder(r.left);
            Console.ReadLine();
            PrintPreOrder(r.right);
            
        }
    }

}
