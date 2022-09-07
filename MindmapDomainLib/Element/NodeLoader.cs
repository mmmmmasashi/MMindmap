using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindmapDomainLib.Element
{
    public class NodeLoader : INodeLoader
    {
        public List<INode> Load()
        {
            return new List<INode>()
            {
                new Node("A", 10, 20),
                new Node("B", 20, 40),
                new Node("C", 30, 60),
            };
        }
    }
}
