using System;
using System.Collections.Generic;

namespace VScode
{
    public class TreeZigZagTraversalC
    {
        public void TreeZigZagTraversal(NodeInt root)
        {
            if (root == null)
                return;
            
            Stack<NodeInt> currentLevel = new Stack<NodeInt>();
            Stack<NodeInt> nextLevel = new Stack<NodeInt>();
            bool leftToRight = true;
            currentLevel.Push(root);

            while (currentLevel.Count > 0 )
            {
                NodeInt node = currentLevel.Pop();
                Console.WriteLine(node.Value);

                if (leftToRight)
                {
                    if (node.left != null) 
                        nextLevel.Push(node.left); 
                    if (node.right != null) 
                        nextLevel.Push(node.right); 
                }
                else
                { 
                    if (node.right != null) 
                        nextLevel.Push(node.right); 
                    if (node.left != null) 
                        nextLevel.Push(node.left); 
                }

                if(currentLevel.Count == 0)
                {
                    leftToRight = !leftToRight;
                    Stack<NodeInt> temp = currentLevel; 
                    currentLevel = nextLevel; 
                    nextLevel = temp;
                }
            }
        }
    }
}