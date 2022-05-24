using System;
using System.Collections.Generic;
using System.Linq;
using static Binary_Tree_Level_Order_Traverse.Program;

namespace Binary_Tree_Level_Order_Traverse
{
    internal class Program
    {
        public class Node<T>
        {
            public T val;
            public Node<T> left;
            public Node<T> right;

            public Node(T val)
            {
                this.val = val;
            }

            public Node(T val, Node<T> left, Node<T> right)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public static List<List<int>> LevelOrderTraversal(Node<int> root)
        {
            
            if (root == null)
            {
                return new List<List<int>> { };
            }
            Queue<Node<int>> q = new Queue<Node<int>>();
            List<List<int>> ar = new List<List<int>> { };


            q.Enqueue(root);
            while (q.Count > 0)
            {
                List<int> subar = new List<int>();
                int count = 0;
                int length = q.Count;
                while (count < length)
                {
                    var currentNode = q.Dequeue();
                    subar.Add(currentNode.val);
                    if (currentNode.left != null)
                    {
                        q.Enqueue(currentNode.left);
                    }
                    if (currentNode.right != null)
                    {
                        q.Enqueue(currentNode.right);
                    }
                    count++;

                }
                ar.Add(subar);
            }

            return ar;
        }
        public static List<int> RightSideView(Node<int> root)
        {
            if (root == null)
            {
                return new List<int> { };
            }
            Queue<Node<int>> q = new Queue<Node<int>>();
            List<int> ar = new List<int> { };


            q.Enqueue(root);
            Node<int> currentNode=null;
            while (q.Count > 0)
            {
                //List<int> subar = new List<int>();
                int count = 0;
                int length = q.Count;
                while (count < length)
                {
                    currentNode = q.Dequeue();
                   
                    if (currentNode.left != null)
                    {
                        q.Enqueue(currentNode.left);
                    }
                    if (currentNode.right != null)
                    {
                        q.Enqueue(currentNode.right);
                    }
                    count++;

                }
               ar.Add(currentNode.val);
            }

            return ar;
        }
        public static Node<T> BuildTree<T>(List<string> strs, ref int pos, Func<string, T> f)
        {
            string val = strs[pos];
            pos++;
            if (val == "x") return null;
            Node<T> left = BuildTree<T>(strs, ref pos, f);
            Node<T> right = BuildTree<T>(strs, ref pos, f);
            return new Node<T>(f(val), left, right);
        }
        public static List<string> SplitWords(string s)
        {
            return string.IsNullOrEmpty(s) ? new List<string>() : s.Trim().Split(' ').ToList();
        }

        static void Main(string[] args)
        {
            List<string> strs = SplitWords(Console.ReadLine());
            int pos = 0;
            Node<int> root = BuildTree(strs, ref pos, int.Parse);
            List<List<int>> res = LevelOrderTraversal(root);
            List<int> list = RightSideView(root);
            foreach (List<int> row in res)
            {
                Console.WriteLine(String.Join(' ', row));
            }
            foreach (int i in list)
            {
                Console.WriteLine(String.Join(' ', i));
            }
        }
    }
}
