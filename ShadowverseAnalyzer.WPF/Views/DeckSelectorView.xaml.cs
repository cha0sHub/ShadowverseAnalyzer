using ShadowverseAnalyzer.Interfaces.Controllers;
using ShadowverseAnalyzer.Interfaces.Views;
using System.Windows.Controls;

namespace ShadowverseAnalyzer.WPF.Views
{
    /// <summary>
    /// Interaction logic for DeckSelectorView.xaml
    /// </summary>
    public partial class DeckSelectorView : Grid, IDeckSelectorView
    {

        private IDeckSelectorController Controller { get; }

        public DeckSelectorView(IDeckSelectorController controller)
        {
            Controller = controller;
            DataContext = controller;
            Controller.SetView(this);

            InitializeComponent();
        }
    }
}
