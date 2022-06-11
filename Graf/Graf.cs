using System.Collections.Generic;

namespace Graf
{
    public class Graf<T>
    {
        private List<Node<T>> nodes = new List<Node<T>>();

        public void addNode(Node<T> node)
        {
            nodes.Add(node);
        }

        public void addEdge(Node<T> nod1, Node<T> nod2, Edge<T> edge)
        {
            nod1.AddEdge(edge);
            nod2.AddEdge(edge);
            edge.AddNode(nod1, nod2);
        }

        public void removeNode(Node<T> node)
        {
            List<Edge<T>> edges = node.getAllEdges();
            foreach (var edge in edges)
            {
                removeEdge(edge);
                
            }
            nodes.Remove(node);
        }

        public void removeEdge(Edge<T> edge)
        {
            Node<T>[] nodes = edge.getNodes();
            nodes[0].RmemoveEdge(edge);
            nodes[1].RmemoveEdge(edge);
            
        }

        public int size()
        {
            return nodes.Count;
        }

        public string printNeighgbour(Node<T> node)
        {
            string txt = node.number + " => [";
            List<Edge<T>> edges = node.getAllEdges();
            foreach (var edge in edges)
            {
                Node<T>[] nodes = edge.getNodes();
                foreach (var nodTemp in nodes)
                {
                    if (nodTemp != node)
                    {
                        txt += node.number + ", ";
                    }
                }
            }

            txt += " ]";
            return txt;
        }
        
    }
}