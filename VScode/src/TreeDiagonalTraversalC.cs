using System;
using System.Collections;
using System.Collections.Generic;

namespace VScode
{
    public class TreeDiagonalTraversalC
    {
        public void TreeDiagonalTraversal(NodeInt root)
        {
            // create a map of list to store Diagonal elements 
            Dictionary<int, List<int>> diagonalPrint = new Dictionary<int, List<int>>();
            diagonalPrintUtil(root, 0, diagonalPrint);

            Console.WriteLine("Diagonal Traversal of Binary Tree");
            // for (Entry<Integer, Vector<Integer>> entry : diagonalPrint.entrySet())
            foreach( KeyValuePair<int, List<int>> kvp in diagonalPrint )
            {
                foreach (var item in kvp.Value)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
                // System.out.println(entry.getValue());
            }
        }
        public void diagonalPrintUtil(NodeInt root, int d,
            Dictionary<int, List<int>> diagonalPrint)
        {

            // Base case 
            if (root == null)
                return;

            // get the list at the particular d value 
            diagonalPrint.TryGetValue(d, out List<int> k);

            // k is null then create a list and store the data 
            if (k == null)
            {
                k = new List<int>();
                k.Add(root.Value);
            }

            // k is not null then update the list 
            else
            {
                k.Add(root.Value);
            }

            // Store all nodes of same line together as a vector 
            diagonalPrint[d] = k;

            // Increase the vertical distance if left child 
            diagonalPrintUtil(root.left, d + 1, diagonalPrint);

            // Vertical distance remains same for right child 
            diagonalPrintUtil(root.right, d, diagonalPrint);
        }
    }
}