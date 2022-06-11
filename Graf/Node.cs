using System.Collections.Generic;

namespace Graf
{
    public class Node<T>
    {
        private T value;
        public int number;
        private int total = 0;
        private List<Edge<T>> edges = new List<Edge<T>>();

        public Node(T value)
        {
            this.value = value;
            total++;
        }
        public void AddEdge(Edge<T> edge)
        {
         edges.Add(edge);   
        }


        public void RmemoveEdge(Edge<T> edge)
        {
            edge.RemoveNode();
            Node<T>[] nodes = edge.getNodes();
            nodes[0].RmemoveEdge(edge);
            nodes[1].RmemoveEdge(edge);
            
        }

        public List<Edge<T>> getAllEdges()
        {
            return edges;
        }
    }
}