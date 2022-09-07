using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindmapDomainLib.Element
{
    internal class Node : INode
    {
        public double X { get; }

        public double Y { get; }

        public string Name { get; }

        public Node(string name, double x, double y)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
}
