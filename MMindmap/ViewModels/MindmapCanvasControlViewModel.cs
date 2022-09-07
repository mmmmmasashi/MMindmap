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
        public ObservableCollection<NodeControlViewModel> Nodes { get; }
        public MindmapCanvasControlViewModel()
        {
            Nodes = new ObservableCollection<NodeControlViewModel>() { };

            var node1 = new NodeControlViewModel(100, 200);
            var node2 = new NodeControlViewModel(200, 400);
            var node3 = new NodeControlViewModel(300, 600);
            Nodes.Add(node1);
            Nodes.Add(node2);
            Nodes.Add(node3);
        }
    }
}
