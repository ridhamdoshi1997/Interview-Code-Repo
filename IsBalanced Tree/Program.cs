using System;
using System.Collections.Generic;
using System.Linq;

namespace IsBalanced_Tree
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
        public static int treeHeight(Node<int> tree)
        {
            if (tree == null)
            {
                return 0;
            }
            int leftHeight = treeHeight(tree.left);
            int rightHeight = treeHeight(tree.right);
            if (leftHeight == -1 || rightHeight == -1)
            {
                return -1;
            }
            if (Math.Abs(leftHeight - rightHeight) > 1)
            {
                return -1;
            }
            return Math.Max(leftHeight, rightHeight) + 1;
        }
        public static bool IsBalanced(Node<int> tree)
        {
            return treeHeight(tree) != -1;
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
            Node<int> tree = BuildTree(strs, ref pos, int.Parse);
            bool res = IsBalanced(tree);
            Console.WriteLine(res);
        }
    }
}
