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

    public class �K�w2��Markdown�ǂݍ���Test
    {
        List<INode> nodes;
        INode node;

        public �K�w2��Markdown�ǂݍ���Test()
        {
            List<string> lines = new List<string>()
            {
                "# �^�C�g��",
                "- ������",
            };

            IMarkdownParser parser = new MarkdownParser();
            nodes = parser.Parse(lines);
        }

        [Fact]
        public void �v�f����2��()
        {
            Assert.Equal(2, nodes.Count());
        }

        [Fact]
        public void ���O�̓^�C�g���Ƃ�����()
        {
            Assert.Equal("�^�C�g��", nodes[0].Name);
            Assert.Equal("������", nodes[1].Name);
        }

        [Fact]
        public void �K�w������()
        {
            Assert.Equal(0, nodes[0].Hierarchy);
            Assert.Equal(1, nodes[1].Hierarchy);
        }
    }
}