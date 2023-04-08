using ShadowverseAnalyzer.Interfaces.Controllers;
using ShadowverseAnalyzer.Interfaces.Views;
using System.Windows;

namespace ShadowverseAnalyzer.WPF.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindow
    {

        private IMainController Controller { get; }

        public MainWindow(IMainController controller)
        {
            Controller = controller;
            DataContext = controller;
            Controller.SetWindow(this);

            InitializeComponent();
        }

        public void ShowWindow()
        {
            ShowDialog();
        }

        public void SetView(IView view)
        {
            ViewPlaceholder.Content = view;
        }

        private void DeckSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            Controller.DisplayDeckSelectorView();
        }

        private void DeckBuilderButton_Click(object sender, RoutedEventArgs e)
        {
            Controller.DisplayDeckBuilderView();
        }

        private void DeckAnalysisButton_Click(object sender, RoutedEventArgs e)
        {
            Controller.DisplayDeckAnalysisView();
        }

        private void PackSimulatorButton_Click(object sender, RoutedEventArgs e)
        {
            Controller.DisplayPackSimulatorView();
        }
    }
}
