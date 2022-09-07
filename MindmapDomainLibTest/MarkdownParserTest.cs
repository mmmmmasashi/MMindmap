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

    public class 階層2つのMarkdown読み込みTest
    {
        List<INode> nodes;
        INode node;

        public 階層2つのMarkdown読み込みTest()
        {
            List<string> lines = new List<string>()
            {
                "# タイトル",
                "- あいう",
            };

            IMarkdownParser parser = new MarkdownParser();
            nodes = parser.Parse(lines);
        }

        [Fact]
        public void 要素数は2つ()
        {
            Assert.Equal(2, nodes.Count());
        }

        [Fact]
        public void 名前はタイトルとあいう()
        {
            Assert.Equal("タイトル", nodes[0].Name);
            Assert.Equal("あいう", nodes[1].Name);
        }

        [Fact]
        public void 階層がある()
        {
            Assert.Equal(0, nodes[0].Hierarchy);
            Assert.Equal(1, nodes[1].Hierarchy);
        }
    }
}