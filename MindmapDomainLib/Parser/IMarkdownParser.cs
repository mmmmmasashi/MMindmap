using MindmapDomainLib.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindmapDomainLib.Parser
{
    internal interface IMarkdownParser
    {
        List<INode> Parse(List<string> lines);
    }
}
