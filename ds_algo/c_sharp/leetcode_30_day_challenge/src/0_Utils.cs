namespace leetcode_30_day_challenge
{
    public partial class Program{
        static int i = 0;
        static int maxValue = 0;
    }
    
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class DLinkedListNode
    {
        public int key;
        public int value;
        public DLinkedListNode previous;
        public DLinkedListNode next;
    }
}