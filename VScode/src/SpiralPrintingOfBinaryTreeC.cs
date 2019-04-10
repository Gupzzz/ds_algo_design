using System;
using System.Collections.Generic;

namespace VScode
{
    class SpiralPrintingOfBinaryTreeC
    {
        public void SpiralPrintingOfABinaryTree(NodeChar node)
        {
            if (node == null)
            {
                return; // NULL check 
            }

            // Create two stacks to store alternate levels 
            Stack<NodeChar> s1 = new Stack<NodeChar>(); // For levels to be printed 
                                                        // from right to left 
            Stack<NodeChar> s2 = new Stack<NodeChar>(); // For levels to be printed 
                                                        // from left to right 

            // Push first level to first stack 's1' 
            s1.Push(node);

            // Keep printing while any of the 
            // stacks has some nodes 
            while (s1.Count > 0 || s2.Count > 0)
            {
                // Print nodes of current level from 
                // s1 and push nodes of next level to s2 
                while (s1.Count > 0)
                {
                    NodeChar temp = s1.Peek();
                    s1.Pop();
                    Console.Write(temp.Value + " ");

                    // Note that is right is pushed before left 
                    if (temp.right != null)
                    {
                        s2.Push(temp.right);
                    }

                    if (temp.left != null)
                    {
                        s2.Push(temp.left);
                    }
                }

                // Print nodes of current level from s2 
                // and push nodes of next level to s1 
                while (s2.Count > 0)
                {
                    NodeChar temp = s2.Peek();
                    s2.Pop();
                    Console.Write(temp.Value + " ");

                    // Note that is left is pushed before right 
                    if (temp.left != null)
                    {
                        s1.Push(temp.left);
                    }
                    if (temp.right != null)
                    {
                        s1.Push(temp.right);
                    }
                }
            }
        }
    }
}