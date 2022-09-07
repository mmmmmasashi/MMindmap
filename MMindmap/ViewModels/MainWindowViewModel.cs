using MMindmap.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace MMindmap.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand ShowMindmapCanvasCommand { get; } 

        public MainWindowViewModel(IRegionManager regionManager)
        {
            ShowMindmapCanvasCommand = new DelegateCommand(() => regionManager.RequestNavigate("ContentRegion", nameof(MindmapCanvasControl)));
        }
    }
}
