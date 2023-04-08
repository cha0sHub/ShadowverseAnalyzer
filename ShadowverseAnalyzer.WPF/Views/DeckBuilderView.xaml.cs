using ShadowverseAnalyzer.Interfaces.Controllers;
using ShadowverseAnalyzer.Interfaces.Views;
using System.Windows.Controls;

namespace ShadowverseAnalyzer.WPF.Views
{
    /// <summary>
    /// Interaction logic for DeckBuilderView.xaml
    /// </summary>
    public partial class DeckBuilderView : Grid, IDeckBuilderView
    {

        private IDeckBuilderController Controller { get; }

        public DeckBuilderView(IDeckBuilderController controller)
        {
            Controller = controller;
            DataContext = controller;
            Controller.SetView(this);

            InitializeComponent();
        }
    }
}
