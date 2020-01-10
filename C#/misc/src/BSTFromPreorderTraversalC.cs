using System.Collections.Generic;

namespace VScode
{
    class BSTFromPreorderTraversalC
    {
        public NodeInt ConstructBSTFromPreorderTraversal(int[] preorderTraversal, int size)
        {
            // The first element of pre[] is always root  
            NodeInt root = new NodeInt(preorderTraversal[0]);

            Stack<NodeInt> s = new Stack<NodeInt>();

            // Push root  
            s.Push(root);

            // Iterate through rest of the size-1 items of given preorder array  
            for (int i = 1; i < size; ++i)
            {
                NodeInt temp = null;

                /* Keep on popping while the next value is greater than  
                 stack's top value. */
                while (s.Count > 0 && preorderTraversal[i] > s.Peek().Value)
                {
                    temp = s.Pop();
                }

                // Make this greater value as the right child 
                // and push it to the stack  
                if (temp != null)
                {
                    temp.right = new NodeInt(preorderTraversal[i]);
                    s.Push(temp.right);
                }

                // If the next value is less than the stack's top 
                // value, make this value as the left child of the  
                // stack's top node. Push the new node to stack  
                else
                {
                    temp = s.Peek();
                    temp.left = new NodeInt(preorderTraversal[i]);
                    s.Push(temp.left);
                }
            }
            return root;
        }
    }
}