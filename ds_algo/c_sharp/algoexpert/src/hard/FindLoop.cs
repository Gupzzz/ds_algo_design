namespace algoexpert
{
    public partial class Program
    {
        // O(n) time | O(1) space
        public static LinkedList FindLoop(LinkedList head)
        {
            LinkedList first = head.Next;
            LinkedList second = head.Next.Next;
            while (first != second)
            {
                first = first.Next;
                second = second.Next.Next;
            }
            first = head;
            while (first != second)
            {
                first = first.Next;
                second = second.Next;
            }
            return first;
        }
    }

    /*
    Test Case 1
    {
      "linkedList": {
        "head": "0",
        "nodes": [
          {"id": "0", "Next": "1", "value": 0},
          {"id": "1", "Next": "2", "value": 1},
          {"id": "2", "Next": "3", "value": 2},
          {"id": "3", "Next": "4", "value": 3},
          {"id": "4", "Next": "5", "value": 4},
          {"id": "5", "Next": "6", "value": 5},
          {"id": "6", "Next": "7", "value": 6},
          {"id": "7", "Next": "8", "value": 7},
          {"id": "8", "Next": "9", "value": 8},
          {"id": "9", "Next": "4", "value": 9}
        ]
      }
    }
    */
}