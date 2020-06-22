/// <summary>
/// Node Tree class
/// </summary>
/// It is used as a Tries, Single Tree
namespace AlgorithmCourse.Data_structures
{
    public class NodeTree<T>
    {
        public T value;
        public NodeTree<T> right;
        public NodeTree<T> left;

        public NodeTree(T value)
        {
            this.value = value;
        }
    }
}
