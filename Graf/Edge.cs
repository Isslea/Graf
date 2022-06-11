namespace Graf
{
    public class Edge<T>
    {
        private Node<T> node1;
        private Node<T> node2;
        private double value;

        public void AddNode(Node<T> node1, Node<T> node2)
        {
            this.node1 = node1;
            this.node2 = node2;
        }

        public void RemoveNode()
            {
                node1 = null;
                node2 = null;
            }
        
        public Node<T>[] getNodes()
        {
            return new Node<T>[] {node1, node2};
        }
        }
    }