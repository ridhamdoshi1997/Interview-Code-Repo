using System;
using System.Collections.Generic;
using System.Linq;

namespace Visible_Tree_Node
{
    

    public class Program
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
        public static int VisibleTreeNode(Node<int> root)
        {

            return Rec(root, double.NegativeInfinity);
        }
        public static int total = 0;
        public static int Rec(Node<int> root, double Max_Val)
        {
           
            if (root == null)
            {
                return total;
            }

            if (root.val >= Max_Val)
            {
                total += 1;

            }
            //Max_Val=root.val;
            int left=Rec(root.left, root.val);
            int right=Rec(root.right, root.val);
            total = Math.Max(right, left);
            return total;
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
            int res = VisibleTreeNode(root);
            Console.WriteLine(res);
        }
    }
}
