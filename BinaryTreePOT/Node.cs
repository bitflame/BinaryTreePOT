using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreePOT
{
    public class Node
    {
        public Int32 key;
        public Node left;
        public Node right; 
        public Node (Int32 item)
        {
            key = item;
            left = right = null;
        }
    }
}
