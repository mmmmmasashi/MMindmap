using MindmapDomainLib.Element;
using MindmapDomainLib.Parser;

namespace MindmapDomainLibTest
{
    public class MarkdownParserTest
    {
        [Fact]
        public void Test1()
        {
            List<string> lines = new List<string>() { "# タイトル" };

            IMarkdownParser parser = new MarkdownParser();
            List<INode> result = parser.Parse(lines);
            Assert.Single(result);
            Assert.Equal("タイトル", result.First().Name);
        }
    }
}