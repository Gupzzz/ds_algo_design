namespace algoexpert
{
// Remove Kth Node From End

// Write a function that takes in the head of a Singly Linked List and an integer k(assume that the list has at 
// least k nodes). The function should remove the kth node from the end of the list.Note that every node in the 
// Singly Linked List has a "value" property storing its value as well as a "next" property pointing to the next 
// node in the list or None(null) if it is the tail of the list.

// Sample input: 0 -> 1 -> 2 -> 3 -> 4 -> 5 -> 6 -> 7 -> 8 -> 9, 4
// Sample output: 0 -> 1 -> 2 -> 3 -> 4 -> 5 -> 7 -> 8 -> 9

public partial class Program
    {
        // O(n) time | O(1) space
        public static void RemoveKthNodeFromEnd(LinkedList head, int k)
        {
            int counter = 1;
            LinkedList first = head;
            LinkedList second = head;
            while (counter <= k)
            {
                second = second.Next;
                counter++;
            }
            if (second == null)
            {
                head.Value = head.Next.Value;
                head.Next = head.Next.Next;
                return;
            }
            while (second.Next != null)
            {
                second = second.Next;
                first = first.Next;
            }
            first.Next = first.Next.Next;
        }

        public class LinkedList
        {
            public int Value;
            public LinkedList Next = null;

            public LinkedList(int value)
            {
                this.Value = value;
            }
        }
    }
}