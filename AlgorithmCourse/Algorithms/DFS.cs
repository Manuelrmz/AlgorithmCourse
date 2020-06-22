using AlgorithmCourse.Data_structures;
using System;
using System.Collections;
using System.Text;

namespace AlgorithmCourse.Algorithms
{
    public class DFS
    {
        public void PrintTree<T>(NodeTree<T> tree)
        {
            Stack<NodeTree<T>> stack = new Stack<NodeTree<T>>();
            Hashtable hs = new Hashtable();
            stack.Push(tree);
            while (!stack.IsEmpty())
            {
                NodeTree<T> node = stack.Pop();
                if (node != null)
                {
                    if (!hs.ContainsKey(node.value))
                    {
                        Console.WriteLine(node.value);
                        hs.Add(node.value, node.value);
                        stack.Push(node.left);
                        stack.Push(node.right);
                    }
                }
            }
        }
    }
}
