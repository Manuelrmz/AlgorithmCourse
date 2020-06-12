using System;

namespace AlgorithmCourse.Data_structures
{
    //First in First Out
    public class Queue<T>
    {
        private Node<T> top;
        private Node<T> last;

        public void Add(T item)
        {
            Node<T> newItem = new Node<T>(item);
            if (top == null)
            {
                top = newItem;
                last = top;
            }
            else
            {
                last.next = newItem;
                last = last.next;
            }

        }

        public T Remove()
        {
            if (top == null)
                throw new System.Exception("Queue Empty");
            var itemToReturn = top;
            top = top.next;
            return itemToReturn.value;
        }

        public T Peek()
        {
            if (top == null)
                throw new System.Exception("Queue Empty");
            return top.value;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void PrintQueue()
        {
            if (top != null)
            {
                var item = top;
                Console.WriteLine("First Value");
                while (item != null)
                {
                    Console.WriteLine($"Value: {item.value}");
                    item = item.next;
                }
                Console.WriteLine("Last Value");
            }
            else
                Console.WriteLine("Empty Queue");
        }

    }
}