using System;
namespace VScode
{
    // https://www.geeksforgeeks.org/write-a-function-to-get-the-intersection-point-of-two-linked-lists/
    public class LinkedListNode
        {
            public int data;
            public LinkedListNode next;

            public LinkedListNode(int d)
            {
                data = d;
                next = null;
            }
        }

    public class LinkedList
    {
        public LinkedListNode head1, head2;
        
        /*function to get the intersection point of two linked  
        lists head1 and head2 */
        public int getNode()
        {
            int c1 = getCount(head1);
            int c2 = getCount(head2);
            int d;

            if (c1 > c2)
            {
                d = c1 - c2;
                return _getIntesectionNode(d, head1, head2);
            }
            else
            {
                d = c2 - c1;
                return _getIntesectionNode(d, head2, head1);
            }
        }

        /* function to get the intersection point of two linked  
        lists head1 and head2 where head1 has d more nodes than  
        head2 */
        public int _getIntesectionNode(int d, LinkedListNode node1, LinkedListNode node2)
        {
            int i;
            LinkedListNode current1 = node1;
            LinkedListNode current2 = node2;
            for (i = 0; i < d; i++)
            {
                if (current1 == null)
                {
                    return -1;
                }
                current1 = current1.next;
            }
            while (current1 != null && current2 != null)
            {
                if (current1.data == current2.data)
                {
                    return current1.data;
                }
                current1 = current1.next;
                current2 = current2.next;
            }

            return -1;
        }

        /*Takes head pointer of the linked list and  
        returns the count of nodes in the list */
        public int getCount(LinkedListNode node)
        {
            LinkedListNode current = node;
            int count = 0;

            while (current != null)
            {
                count++;
                current = current.next;
            }

            return count;
        }
    }
}