using MindmapDomainLib.Element;
using MindmapDomainLib.Parser;
using System;
using Xunit;

namespace MindmapDomainLibTest
{
    public class 見出し1はトップノードTest
    {
        List<INode> nodes;
        INode node;

        public 見出し1はトップノードTest()
        {
            List<string> lines = new List<string>() { "# タイトル" };
            IMarkdownParser parser = new MarkdownParser();
            nodes = parser.Parse(lines);
            node = nodes.First();
        }

        [Fact]
        public void 見出し1はノードとして名前が取れる()
        {
            Assert.Single(nodes);
            Assert.Equal("タイトル", nodes.First().Name);
        }

        [Fact]
        public void 階層はトップなので0()
        {
            Assert.Equal(0, node.Hierarchy);
        }
    }
}