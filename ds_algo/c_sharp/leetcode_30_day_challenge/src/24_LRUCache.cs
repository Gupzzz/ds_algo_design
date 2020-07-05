using System.Collections.Generic;

namespace leetcode_30_day_challenge{
    public class LRUCache
    {
        /**
         * Always add the new node right after head;
         */
        private void addNode(DLinkedListNode node)
        {

            node.previous = head;
            node.next = head.next;

            head.next.previous = node;
            head.next = node;
        }

        /**
         * Remove an existing node from the linked list.
         */
        private void removeNode(DLinkedListNode node)
        {
            DLinkedListNode previous = node.previous;
            DLinkedListNode next = node.next;

            previous.next = next;
            next.previous = previous;
        }

        /**
         * Move certain node in between to the head.
         */
        private void moveToHead(DLinkedListNode node)
        {
            this.removeNode(node);
            this.addNode(node);
        }

        // pop the current tail. 
        private DLinkedListNode popTail()
        {
            DLinkedListNode res = tail.previous;
            this.removeNode(res);
            return res;
        }

        private Dictionary<int, DLinkedListNode>
          cache = new Dictionary<int, DLinkedListNode>();
        private int count;
        private int capacity;
        private DLinkedListNode head, tail;

        public LRUCache(int capacity)
        {
            this.count = 0;
            this.capacity = capacity;

            head = new DLinkedListNode();
            head.previous = null;

            tail = new DLinkedListNode();
            tail.next = null;

            head.next = tail;
            tail.previous = head;
        }

        public int get(int key)
        {

            DLinkedListNode node = cache[key];
            if (node == null)
            {
                return -1; // should raise exception here.
            }

            // move the accessed node to the head;
            this.moveToHead(node);

            return node.value;
        }


        public void put(int key, int value)
        {
            DLinkedListNode node = cache[key];

            if (node == null)
            {

                DLinkedListNode newNode = new DLinkedListNode();
                newNode.key = key;
                newNode.value = value;

                this.cache.Add(key, newNode);
                this.addNode(newNode);

                ++count;

                if (count > capacity)
                {
                    // pop the tail
                    DLinkedListNode tail = this.popTail();
                    this.cache.Remove(tail.key);
                    --count;
                }
            }
            else
            {
                // update the value.
                node.value = value;
                this.moveToHead(node);
            }
        }

    }
}