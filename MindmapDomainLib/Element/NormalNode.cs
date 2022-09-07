using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindmapDomainLib.Element
{
    internal class NormalNode : INode
    {
        public string Name { get; }

        public double X => throw new NotImplementedException();

        public double Y => throw new NotImplementedException();

        public int Hierarchy => 1;

        public NormalNode(string name)
        {
            Name = name;
        }
    }
}
