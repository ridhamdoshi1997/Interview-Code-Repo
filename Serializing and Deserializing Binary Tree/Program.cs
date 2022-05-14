using System;
using System.Collections.Generic;
using System.Linq;

namespace Serializing_and_Deserializing_Binary_Tree
{
    internal class Program
    {
        public static string s;
        public static String serialize(Node<int> root)
        {
            // WRITE YOUR BRILLIANT CODE HERE
            if (root == null)
            {
                s = s + "x";
                return s;
            }
            s = s + root.val.ToString();
            serialize(root.left);
            serialize(root.right);
            return s;
        }

        //public static Node<int> deserialize(String root)
        //{
        //    char[] ch = root.ToString().ToCharArray();
        //    Node<int> node = new Node<int>(int.Parse(ch[0].ToString()));
        //    return deser(ch,node);
            
        //}
        public static int i = 0;
        //public static Node<int> deser(char[] root, Node<int> node)
        //{
            
        //    if(root[i] == 'x')
        //    {
        //        node = null;
        //        i++;
        //        return node;
                
        //    }
        //    else 
        //    {
        //        node = new Node<int>(int.Parse(root[i].ToString()));
        //        node.val = root[i];
        //        i++;
        //    }
        //    deser();
        //}

        /** Driver class, do not change **/
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
            string s = serialize(tree);
            //Node<int> newRoot = deserialize(serialize(tree));
            //List <String> output = new List<string>();
            //printTree(newRoot, output);
            Console.WriteLine(s);
        }

        private static void printTree(Node<int> root, List<string> output)
        {
            if (root == null)
            {
                output.Add("x");
            }
            else
            {
                output.Add(root.val.ToString());
                printTree(root.left, output);
                printTree(root.right, output);
            }
        }
    }
}
