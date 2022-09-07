using MindmapDomainLib.Element;
using MindmapDomainLib.Parser;
using System;
using Xunit;

namespace MindmapDomainLibTest
{
    public class ���o��1�̓g�b�v�m�[�hTest
    {
        List<INode> nodes;
        INode node;

        public ���o��1�̓g�b�v�m�[�hTest()
        {
            List<string> lines = new List<string>() { "# �^�C�g��" };
            IMarkdownParser parser = new MarkdownParser();
            nodes = parser.Parse(lines);
            node = nodes.First();
        }

        [Fact]
        public void ���o��1�̓m�[�h�Ƃ��Ė��O������()
        {
            Assert.Single(nodes);
            Assert.Equal("�^�C�g��", nodes.First().Name);
        }

        [Fact]
        public void �K�w�̓g�b�v�Ȃ̂�0()
        {
            Assert.Equal(0, node.Hierarchy);
        }
    }
}