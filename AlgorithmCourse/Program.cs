using AlgorithmCourse.Algorithms;
using AlgorithmCourse.Data_structures;
using System;
/* 
 * Topics:
 * Time / Space Complexity
 * Data Structures: Hash map, LikedList, Stacks, Queues, Trees, Heaps, Tries, Graphs
 * Algorithms: Quicksort, Merge sort, Binary Search, depth-first search, breadth-first search
 * 
 * Data Structure               Algorithms                Concepts
 * LinkedList            *  |   Breadth-First search  |  Bit Manipulation
 * Trees/Tries/Graphs   *   |   Depth- First search   |  Memory (stack vs heap)
 * Stacks/Queues        *   |   Binary Search         |  Recursion
 * Heaps                *   |   Merge Sort            |  Dynamic Programming
 * Vectors / ArrayList *    |   Quick sort            |  Big o Time & Space
 * Hash tables   * 
 * 
 * 
 * List<> is the same as an array expect that the Array has a fixed lenght, in the other hand when List<> run out of space it generate a new array with the double of size
 * and then insert all the values from the previous array.
 * 
 * LinkedList is different from a list because a each member of the list has a reference to the previous and next item.
 * 
 * DataStructure     |   Equivalent in C#
 * ArrayList         |    List<>
 * Vector            |    Array
 * LinkedList        |    LinkedList
 * Hash Table        |    Hash Table
 * 
 * 
 */
namespace AlgorithmCourse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Queue
            /*
            Queue<int> myQueue = new Queue<int>();
            myQueue.PrintQueue();
            myQueue.Add(1);
            myQueue.Add(2);
            myQueue.Add(3);
            myQueue.Add(4);
            myQueue.Add(5);
            myQueue.PrintQueue();
            System.Console.WriteLine($"ItemRemoved: {myQueue.Remove()}");
            myQueue.PrintQueue();
            System.Console.WriteLine($"ItemRemoved: {myQueue.Remove()}");
            System.Console.WriteLine($"ItemRemoved: {myQueue.Remove()}");
            System.Console.WriteLine($"ItemRemoved: {myQueue.Remove()}");
            System.Console.WriteLine($"ItemRemoved: {myQueue.Remove()}");
            System.Console.WriteLine($"ItemRemoved: {myQueue.Remove()}");
            myQueue.PrintQueue();
            myQueue.Add(1);
            myQueue.PrintQueue();
            System.Console.ReadLine();
            */
            //Stack
            /*Stack<int> myQueue = new Stack<int>();
            myQueue.PrintStack();
            myQueue.Push(1);
            myQueue.Push(2);
            myQueue.Push(3);
            myQueue.Push(4);
            myQueue.Push(5);
            myQueue.PrintStack();
            System.Console.WriteLine($"ItemRemoved: {myQueue.Pop()}");
            myQueue.PrintStack();
            System.Console.WriteLine($"ItemRemoved: {myQueue.Pop()}");
            System.Console.WriteLine($"ItemRemoved: {myQueue.Pop()}");
            System.Console.WriteLine($"ItemRemoved: {myQueue.Pop()}");
            System.Console.WriteLine($"Item Extracted: {myQueue.Peek()}");
            System.Console.WriteLine($"ItemRemoved: {myQueue.Pop()}");
            myQueue.PrintStack();
            myQueue.Push(1);
            myQueue.PrintStack();
            System.Console.ReadLine();*/

            int values = 10000000;
            int[] example = new int[values];
            var watch = new System.Diagnostics.Stopwatch();
            Random random = new Random();
            Console.WriteLine("Genereting values: ");
            watch.Start();
            for(int i = 0; i < values; i++)
            {
                example[i] = random.Next(1, values);
            }
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            MergeSort ms = new MergeSort();
            BubbleSort bs = new BubbleSort();
            QuickSort qs = new QuickSort();
            watch.Reset();
            watch.Start();
            var result = ms.Sort(example);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            //watch.Reset();
            //watch.Start();
            //var result2 = bs.Sort(example);
            //watch.Stop();
            //Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            /*int[] example = new int[]
            {
                20,19,18,17,16,15,14,13,12,11,10,9,8,7,6,5,4,3,2,1
            };*/
            watch.Reset();
            example = new int[values];
            for (int i = 0; i < values; i++)
            {
                example[i] = random.Next(1, values);
            }
            watch.Start();
            var result3 = qs.Sort(example);
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            /*NodeTree<string> alphabet = new NodeTree<string>("A");
            alphabet.left = new NodeTree<string>("B");
            alphabet.right = new NodeTree<string>("C");
            alphabet.left.left = new NodeTree<string>("D");
            alphabet.left.right = new NodeTree<string>("E");
            alphabet.right.left = new NodeTree<string>("F");
            alphabet.right.right = new NodeTree<string>("G");
            BFS bfs = new BFS();
            DFS dfs = new DFS();
            Console.WriteLine("BFS");
            bfs.PrintTree<string>(alphabet);
            Console.WriteLine("DFS");
            dfs.PrintTree<string>(alphabet);*/
            Console.ReadLine();
        }
    }
}
