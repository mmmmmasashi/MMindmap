using MindmapDomainLib.Element;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MMindmap.ViewModels
{
    public class MindmapCanvasControlViewModel : BindableBase
    {
        private readonly INodeLoader _nodeLoader;

        public ObservableCollection<INode> Nodes { get; } = new ObservableCollection<INode>();
        public MindmapCanvasControlViewModel(INodeLoader nodeLoader)
        {
            _nodeLoader = nodeLoader;

            var nodes = nodeLoader.Load();
            Nodes.AddRange(nodes);
        }
    }
}
