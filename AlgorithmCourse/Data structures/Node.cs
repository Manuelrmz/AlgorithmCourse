namespace AlgorithmCourse.Data_structures
{
    public class Node<T>
    {
        public T value;
        public Node<T> next;

        public Node(T node)
        {
            this.value = node;
        }

        public void Next(Node<T> node)
        {
            if (this.next == null)
                this.next = node;
            else
                this.Next(node);
                
        }
    }
}
