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
    }
}
