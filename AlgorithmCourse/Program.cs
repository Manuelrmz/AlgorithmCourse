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

            /*int values = 100000;
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
            watch.Reset();
            watch.Start();
            var result = ms.Sort(example);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            watch.Reset();
            watch.Start();
            var result2 = bs.Sort(example);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");*/

            int[] example = new int[]
            {
                20,19,18,17,16,15,14,13,12,11,10,9,8,7,6,5,4,3,2,1
            };
            QuickSort qs = new QuickSort();
            var result = qs.Sort(example);
            Console.ReadLine();
        }
    }
}
