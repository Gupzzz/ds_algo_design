using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VScode
{
    public class ConstructTreeFromTraversal
    {
        int preOrderIndex = 0;

        public Node BuildTree(char[] inOrderTraversal, char[] preOrderTraversal, int inOrderStart, int inOrderEnd)
        {
            if (inOrderStart > inOrderEnd)
            {
                return null;
            }

            Node tNode = new Node(preOrderTraversal[preOrderIndex++]);

            if (inOrderStart == inOrderEnd)
            {
                return tNode;
            }

            int inOrderIndex = Search(inOrderTraversal, inOrderStart, inOrderEnd, tNode.Value);

            tNode.left = BuildTree(inOrderTraversal, preOrderTraversal, inOrderStart, inOrderIndex - 1);
            tNode.right = BuildTree(inOrderTraversal, preOrderTraversal, inOrderIndex + 1, inOrderEnd);

            return tNode;
        }

        int Search(char[] inOrderTraversal, int start, int end, char value)
        {
            int i;
            for (i = start; i <= end; i++)
            {
                if (inOrderTraversal[i] == value)
                    return i;
            }
            return i;
        }
    }
}
