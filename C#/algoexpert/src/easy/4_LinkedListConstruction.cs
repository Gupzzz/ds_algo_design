namespace algoexpert
{
// ​Linked List Construction

// Write a class for a Doubly Linked List.The class should have a "head" and "tail" 
// properties, both of which should point to either the None(null) value or to a Linked List node.
// Every node will have a "value" property as well as "next" and "prev" properties, both of which 
// can point to either the None(null) value or another node.The class should support setting the 
// head and tail of the linked list, inserting nodes before and after other nodes as well as at 
// certain positions, removing given nodes and removing nodes with specific values, and searching 
// for nodes with values.Only the searching method should return a value: specifically, a boolean.

// Sample input:
// 1 -> 2 -> 3 -> 4 -> 5
// Sample output (after setting 4 to head):
// 4 -> 1 -> 2 -> 3 -> 5
// Sample output(after setting 6 to tail):
// 4 -> 1 -> 2 -> 3 -> 5 -> 6
// Sample output(after inserting 3 before 6):
// 4 -> 1 -> 2 -> 5 -> 3 -> 6
// Sample output(after inserting a new 3 after 6):
// 4 -> 1 -> 2 -> 5 -> 3 -> 6 -> 3
// Sample output(after inserting a new 3 at position 1):
// 3 -> 4 -> 1 -> 2 -> 5 -> 3 -> 6 -> 3
// Sample output(after removing nodes with value 3):
// 4 -> 1 -> 2 -> 5 -> 6
// Sample output(after removing 2):
// 4 -> 1 -> 5 -> 6
// Sample output(after searching for 5): True
public partial class Program
    {
        public class DoublyLinkedList
        {
            public Node Head;
            public Node Tail;

            // O(1) time | O(1) space
            public void SetHead(Node node)
            {
                if (Head == null)
                {
                    Head = node;
                    Tail = node;
                    return;
                }
                InsertBefore(Head, node);
            }

            // O(1) time | O(1) space
            public void SetTail(Node node)
            {
                if (Tail == null)
                {
                    SetHead(node);
                    return;
                }
                InsertAfter(Tail, node);
            }

            // O(1) time | O(1) space
            public void InsertBefore(Node node, Node nodeToInsert)
            {
                if (nodeToInsert == Head && nodeToInsert == Tail) return;
                Remove(nodeToInsert);
                nodeToInsert.Prev = node.Prev;
                nodeToInsert.Next = node;
                if (node.Prev == null)
                {
                    Head = nodeToInsert;
                }
                else
                {
                    node.Prev.Next = nodeToInsert;
                }
                node.Prev = nodeToInsert;
            }

            // O(1) time | O(1) space
            public void InsertAfter(Node node, Node nodeToInsert)
            {
                if (nodeToInsert == Head && nodeToInsert == Tail) return;
                Remove(nodeToInsert);
                nodeToInsert.Prev = node;
                nodeToInsert.Next = node.Next;
                if (node.Next == null)
                {
                    Tail = nodeToInsert;
                }
                else
                {
                    node.Next.Prev = nodeToInsert;
                }
                node.Next = nodeToInsert;
            }

            // O(p) time | O(1) space
            public void InsertAtPosition(int position, Node nodeToInsert)
            {
                if (position == 1)
                {
                    SetHead(nodeToInsert);
                    return;
                }
                Node node = Head;
                int currentPosition = 1;
                while (node != null && currentPosition++ != position) node = node.Next;
                if (node != null)
                {
                    InsertBefore(node, nodeToInsert);
                }
                else
                {
                    SetTail(nodeToInsert);
                }
            }

            // O(n) time | O(1) space
            public void RemoveNodesWithValue(int value)
            {
                Node node = Head;
                while (node != null)
                {
                    Node nodeToRemove = node;
                    node = node.Next;
                    if (nodeToRemove.Value == value) Remove(nodeToRemove);
                }
            }

            // O(1) time | O(1) space
            public void Remove(Node node)
            {
                if (node == Head) Head = Head.Next;
                if (node == Tail) Tail = Tail.Prev;
                RemoveNodeBindings(node);
            }

            // O(n) time | O(1) space
            public bool ContainsNodeWithValue(int value)
            {
                Node node = Head;
                while (node != null && node.Value != value) node = node.Next;
                return node != null;
            }

            public void RemoveNodeBindings(Node node)
            {
                if (node.Prev != null) node.Prev.Next = node.Next;
                if (node.Next != null) node.Next.Prev = node.Prev;
                node.Prev = null;
                node.Next = null;
            }
        }

        public class Node
        {
            public int Value;
            public Node Prev;
            public Node Next;

            public Node(int value)
            {
                this.Value = value;
            }
        }
    }
}