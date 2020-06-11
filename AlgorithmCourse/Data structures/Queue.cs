namespace AlgorithmCourse.Data_structures
{
    //First in First Out
    public class Queue<T>
    {
        private Node<T> top;
        
        public void Add(T item)
        {
            if(top == null)
            {
                top = new Node<T>(item);
            }
            else
                top.Next(new Node<T>(item));
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
    }
}
