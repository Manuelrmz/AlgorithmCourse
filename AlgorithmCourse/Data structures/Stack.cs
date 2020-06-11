namespace AlgorithmCourse.Data_structures
{
    //Last In First Out
    public class Stack<T>
    {
        private Node<T> top;
        public void Push(T item)
        {
            var newNode = new Node<T>(item);
            newNode.next = top;
            top = newNode;
        }

        public T Pop()
        {
            if (top == null)
                throw new System.Exception("Empty Stack");
            var itemToReturn = top;
            top = top.next;
            return itemToReturn.value;
        }

        public T Peek()
        {
            if (top == null)
                throw new System.Exception("Empty Stack");
            return top.value;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}
