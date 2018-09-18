using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VScode
{
    public class TreeTraversals
    {
        // root, left, right
        public void PreOrderTreeTraversal(Node node)
        {
            if (node == null)
                return;

            Console.Write(node.Value + " ");

            PreOrderTreeTraversal(node.left);

            PreOrderTreeTraversal(node.right);
        }

        // left, root, right
        public void InOrderTreeTraversal(Node node)
        {
            if (node == null)
                return;

            InOrderTreeTraversal(node.left);

            Console.Write(node.Value + " ");
            
            InOrderTreeTraversal(node.right);
        }

        // left, right, root
        public void PostOrderTreeTraversal(Node node)
        {
            if (node == null)
                return;

            PostOrderTreeTraversal(node.left);

            PostOrderTreeTraversal(node.right);

            Console.Write(node.Value + " ");            
        }
    }

    public class Node
    {
        public Node(char value)
        {
            Value = value;
            left = right = null;
        }

        public char Value { get; set; }

        public Node left, right;
    }
}
