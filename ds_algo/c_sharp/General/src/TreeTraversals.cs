using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace general
{
    public class TreeTraversals
    {
        // root, left, right
        public void PreOrderTreeTraversal(NodeChar node)
        {
            if (node == null)
                return;

            Console.Write(node.Value + " ");

            PreOrderTreeTraversal(node.left);

            PreOrderTreeTraversal(node.right);
        }
        public void PreOrderTreeTraversal(NodeInt node)
        {
            if (node == null)
                return;

            Console.Write(node.Value + " ");

            PreOrderTreeTraversal(node.left);

            PreOrderTreeTraversal(node.right);
        }

        // left, root, right
        public void InOrderTreeTraversal(NodeChar node)
        {
            if (node == null)
                return;

            InOrderTreeTraversal(node.left);

            Console.Write(node.Value + " ");
            
            InOrderTreeTraversal(node.right);
        }
        public void InOrderTreeTraversal(NodeInt node)
        {
            if (node == null)
                return;

            InOrderTreeTraversal(node.left);

            Console.Write(node.Value + " ");
            
            InOrderTreeTraversal(node.right);
        }

        // left, right, root
        public void PostOrderTreeTraversal(NodeChar node)
        {
            if (node == null)
                return;

            PostOrderTreeTraversal(node.left);

            PostOrderTreeTraversal(node.right);

            Console.Write(node.Value + " ");            
        }
        public void PostOrderTreeTraversal(NodeInt node)
        {
            if (node == null)
                return;

            PostOrderTreeTraversal(node.left);

            PostOrderTreeTraversal(node.right);

            Console.Write(node.Value + " ");            
        }
    }

    public class NodeChar
    {
        public NodeChar(char value)
        {
            Value = value;
            left = right = null;
        }

        public char Value { get; set; }

        public NodeChar left, right;
    }
    public class NodeInt
    {
        public NodeInt(int value)
        {
            Value = value;
            left = right = null;
        }

        public int Value { get; set; }

        public NodeInt left, right;
    }
    public class NodeString
    {
        public NodeString(string value)
        {
            Value = value;
            left = right = null;
        }

        public string Value { get; set; }

        public NodeString left, right;
    }
}
