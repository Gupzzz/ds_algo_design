using System;

namespace leetcode_30_day_challenge{
    public partial class Program{
        public static ListNode MiddleOfLinkedList(ListNode head){
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }
        public static void _MiddleOfLinkedList(){
            ListNode node = new ListNode(10);
            ListNode head = node;
            ListNode ptr = node;

            node = new ListNode(20);
            ptr.next = node;
            ptr = ptr.next;

            node = new ListNode(30);
            ptr.next = node;
            ptr = ptr.next;

            node = new ListNode(40);
            ptr.next = node;
            ptr = ptr.next;

            node = new ListNode(50);
            ptr.next = node;
            ptr = ptr.next;

            node = new ListNode(60);
            ptr.next = node;
            ptr = ptr.next;

            ptr.next = null;

            ptr = head;
            while(ptr != null)
            {
                Console.Write(ptr.val + "\t");
                ptr = ptr.next;
            }
            Console.WriteLine();

            ptr = MiddleOfLinkedList(head);
            Console.WriteLine("The middle elemement is : " + ptr.val);
        }
    }
}