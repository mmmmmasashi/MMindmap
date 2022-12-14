using MindmapDomainLib.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindmapDomainLib.Parser
{
    internal class MarkdownParser : IMarkdownParser
    {
        public List<INode> Parse(List<string> lines)
        {
            List<INode> nodes = new List<INode>();
            foreach (var line in lines)
            {
                const string header = "# ";
                if (line.StartsWith("# "))
                {
                    nodes.Add(new TopNode(line.Substring(2)));
                }
                else if (line.StartsWith("- "))
                {
                    nodes.Add(new NormalNode(line.Substring(2)));
                }
            }
            return nodes;
        }
    }
}
