using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Root to leaf path sum equal to a given number
// https://www.geeksforgeeks.org/root-to-leaf-path-sum-equal-to-a-given-number/
namespace VScode
{
    public class RootToLeafSum
    {
        public bool FindRootToLeafSum(NodeInt node, int sum)
        {
            // if (node == null)
            // {
            //     return (sum == 0);
            // }

            int mySum = sum - node.Value;
            bool result = false;
            if (mySum == 0 && node.left == null && node.right == null)
            {
                return true;
            }
            if(mySum > 0 && node.left != null)
            {
                result = result || FindRootToLeafSum(node.left, mySum);
            }
            if(mySum > 0 && node.right != null)
            {
                result = result || FindRootToLeafSum(node.right, mySum);
            }
            return result;
        }
    }
}
