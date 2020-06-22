using AlgorithmCourse.Data_structures;
using System;
using System.Collections;

namespace AlgorithmCourse.Algorithms
{
    public class BFS
    {
        public void PrintTree<T>(NodeTree<T> tree)
        {
            Queue<NodeTree<T>> queue = new Queue<NodeTree<T>>();
            Hashtable hs = new Hashtable();
            queue.Add(tree);
            while(!queue.IsEmpty())
            {
                NodeTree<T> node = queue.Remove();
                if (node != null)
                {
                    if (!hs.ContainsKey(node.value))
                    {
                        Console.WriteLine(node.value);
                        hs.Add(node.value, node.value);
                        queue.Add(node.left);
                        queue.Add(node.right);
                    }
                }
            }
        }
    }
}
