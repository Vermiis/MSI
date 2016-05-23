using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSI
{

    public class Node
    {
        public string Name { get; set; }
        public double Distance { get; set; }
        public List<Node> Children { get; set; }
        

        public Node (string name, double distance)
        {
            Name = name;
            Distance = distance;
            Children = new List<Node>();        
        }
        public Node (string name)
        {
            Name = name;
            Distance = 0;
            Children = new List<Node>();
        }
    }


    class Program
    { 

        static void Main(string[] args)
        {
            Node A = new Node("A");
            Node B = new Node("B");
            Node C = new Node("C");
            Node D = new Node("D");
            Node E = new Node("E");
            Node F = new Node("F");
            Node G = new Node("G");
            Node H = new Node("H");
            Node I = new Node("I");

            A.Children.Add(B);
            A.Children.Add(C);
            A.Children.Add(D);
            B.Children.Add(E);
            B.Children.Add(F);
            C.Children.Add(G);
            C.Children.Add(H);
            D.Children.Add(I);

            A.Distance = 0;
            B.Distance = 20;
            C.Distance = 30;
            D.Distance = 10;
            E.Distance = 10;
            F.Distance = 5;
            G.Distance = 4;
            H.Distance = 3;
            I.Distance = 2;


            GraphAlgorithms.DFSearch x = new GraphAlgorithms.DFSearch();
            x.Search(A, "F");
            GraphAlgorithms.MassSearch y = new GraphAlgorithms.MassSearch();
            Console.WriteLine("Dystans");
            Console.WriteLine( y.SearchDistance(A, "I"));
        }
    }
}
