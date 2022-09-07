using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MMindmap.ViewModels
{
    public class NodeControlViewModel : BindableBase
    {
        private double _top;
        public double Top
        {
            get { return _top; }
            set { SetProperty(ref _top, value); }
        }

        private double _left;
        public double Left
        {
            get { return _left; }
            set { SetProperty(ref _left, value); }
        }

        public NodeControlViewModel()
        {

        }

        public NodeControlViewModel(double top, double left)
        {
            this.Top = top;
            this.Left = left;
        }
    }
}
