using ShadowverseAnalyzer.Interfaces.Controllers;
using ShadowverseAnalyzer.Interfaces.Views;
using System.Windows.Controls;

namespace ShadowverseAnalyzer.WPF.Views
{
    /// <summary>
    /// Interaction logic for DeckAnalyzerView.xaml
    /// </summary>
    public partial class DeckAnalysisView : Grid, IDeckAnalysisView
    {
        private IDeckAnalysisController Controller { get; }

        public DeckAnalysisView(IDeckAnalysisController controller)
        {
            Controller = controller;
            DataContext = controller;
            Controller.SetView(this);

            InitializeComponent();
        }
    }
}
