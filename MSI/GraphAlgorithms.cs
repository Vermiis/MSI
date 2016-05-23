using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSI
{
    class GraphAlgorithms
    {
        public abstract class SearchMethod
        {
            protected List<Node> _openList;
            protected List<Node> _closedList;

            protected abstract void InsertChildren(List<Node> children);

            public Node Search(Node startNode, string endNodeName)
            {
                var result = new Node("", 0);
                _openList = new List<Node>();
                _closedList = new List<Node>();

                _openList.Add(startNode);

                while (_openList.Any())
                {

                    var visited = _openList.FirstOrDefault();
                    Console.WriteLine($"Visited Node : {visited.Name} ");

                    if (visited.Name == endNodeName)
                    {
                        result = visited;
                        break;
                    }
                    else
                    {
                        InsertChildren(visited.Children);

                    }

                    _openList.Remove(visited);
                    _closedList.Add(visited);

                    _openList = _openList
                        .Where(x => !_closedList.Any(y => y.Name == x.Name)).ToList();


                }
                return result;
            }
        }

        public class DFSearch : SearchMethod
        {
            protected override void InsertChildren(List<Node> children)
            {
               _openList.InsertRange(0,children);
            }
        }

        public class BFSearch : SearchMethod
        {
            protected override void InsertChildren(List<Node> children)
            {
                _openList.InsertRange(0, children);
            }
        }

        public class MassSearch : SearchMethod
        {
            protected override void InsertChildren(List<Node> children)
            {
                _openList.InsertRange(0, children);
            }
            public double SearchDistance(Node startnode, string endnode)
            {
                double distance = 0;
                _openList = new List<Node>();
                _closedList = new List<Node>();

                _openList.Add(startnode);


                while (_openList.Any())
                {

                    var visited = _openList.FirstOrDefault();
                    Console.WriteLine(@"Visited Node:" + visited.Name);

                    //distance += visited.Distance;
                    //ccc
                    if (visited.Name == endnode)
                    {

                        break;
                    }
                    else
                    {
                        InsertChildren(visited.Children);

                    }

                    _openList.Remove(visited);
                    _closedList.Add(visited);

                    _openList = _openList
                        .Where(x => !_closedList.Any(y => y.Name == x.Name)).ToList();


                }


                foreach (var item in _closedList)
                {
                    if (item.Name != endnode)
                    {
                        distance += item.Distance;
                    }
                }
                return distance;
            }

        }

        //algorytm zachlanny
        //graf z nazwami miejscowosci b
        public class FirstBestSearch : SearchMethod
        {
            protected int Distances (List<Node> visited)
            {
                
                foreach (var item in visited)
                {
                    var a=item.Distance;
                }
                return 0;
            }
            protected override void InsertChildren(List<Node> children)
            {
               
                _openList.InsertRange(0, children);
            }
        }
    }




}
