using System;
using System.Collections.Generic;

namespace Rotate_List
{
    internal class Program
    {
        ListNode head;
        public class ListNode
        {
              public int val;
              public ListNode next;
              public ListNode(int val = 0, ListNode next = null)
              {
                        this.val = val;
                        this.next = next;
              }
           
        }
        void  push(int new_data)
        {
            /* 1 & 2: Allocate the Node &
                    Put in the data*/
            ListNode new_node = new ListNode(new_data);

            /* 3. Make next of new Node as head */
            new_node.next = head;

            /* 4. Move the head to point to new Node */
            head = new_node;
        }
        void printList()
        {
            ListNode temp = head;
            while (temp != null)
            {
                Console.Write(temp.val + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        public ListNode RotateRight(int k)
        {
            if ((head == null) || (head.next == null) || (k == 0)) return head;
            ListNode current = head;

            while (current.next != null)
            {
                current = current.next;
            }

            current.next = head;
            current = head;
            for (int i = 0; i < k-1 ; i++)
            {
                current = current.next;
            }
            head = current.next;
            current.next = null;
            return head;
        }
        static void Main(string[] args)
        {
            Program llist = new Program();

            // create a list 10->20->30->40->50->60
            for (int i = 60; i >= 10; i -= 10)
              llist.push(i);

            llist.RotateRight(4);
            llist.printList();
            Console.WriteLine("Hello World!");
        }
    }
}
