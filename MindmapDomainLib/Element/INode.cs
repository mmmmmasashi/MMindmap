using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindmapDomainLib.Element
{
    public interface INode
    {
        string Name { get; }
        double X { get; }
        double Y { get; }

    }
}
