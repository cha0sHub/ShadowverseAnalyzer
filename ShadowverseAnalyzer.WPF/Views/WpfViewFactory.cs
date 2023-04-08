using ShadowverseAnalyzer.Interfaces.Controllers;
using ShadowverseAnalyzer.Interfaces.Views;

namespace ShadowverseAnalyzer.WPF.Views
{
    internal class WpfViewFactory : IViewFactory
    {
        public IDeckAnalysisView CreateDeckAnalysisView(IDeckAnalysisController controller)
        {
            return new DeckAnalysisView(controller);
        }

        public IDeckBuilderView CreateDeckBuilderView(IDeckBuilderController controller)
        {
            return new DeckBuilderView(controller);
        }

        public IDeckSelectorView CreateDeckSelectorView(IDeckSelectorController controller)
        {
            return new DeckSelectorView(controller);
        }

        public IMainWindow CreateMainWindow(IMainController controller)
        {
            return new MainWindow(controller);
        }

        public IPackSimulatorView CreatePackSimulatorView(IPackSimulatorController controller)
        {
            return new PackSimulatorView(controller);
        }
    }
}
