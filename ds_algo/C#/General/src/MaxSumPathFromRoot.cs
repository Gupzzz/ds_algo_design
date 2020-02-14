using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given a tree with non-negative node values, find the maximum cost
// of a path starting from the root node.
namespace VScode
{
    public class MaxPathFromRoot
    {
      public int FindMaxPathFromRoot(NodeInt node){
        if (node == null)
        {
            return 0;
        }
        int leftNodeSum = FindMaxPathFromRoot(node.left);
        int rightNodeSum = FindMaxPathFromRoot(node.right);
        return node.Value + Math.Max(leftNodeSum, rightNodeSum);
      }
    }
}
