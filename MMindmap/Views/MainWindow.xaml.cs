using MMindmap.ViewModels;
using System.Windows;

namespace MMindmap.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadedEvent(object sender, RoutedEventArgs e)
        {
            var vm = (MainWindowViewModel)this.DataContext;
            vm.ShowMindmapCanvasCommand.Execute();
        }
    }
}
