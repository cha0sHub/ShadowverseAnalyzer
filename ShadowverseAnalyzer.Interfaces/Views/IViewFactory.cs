using ShadowverseAnalyzer.Interfaces.Controllers;

namespace ShadowverseAnalyzer.Interfaces.Views
{
    public interface IViewFactory
    {
        IDeckAnalysisView CreateDeckAnalysisView(IDeckAnalysisController controller);
        IDeckBuilderView CreateDeckBuilderView(IDeckBuilderController controller);
        IDeckSelectorView CreateDeckSelectorView(IDeckSelectorController controller);
        IMainWindow CreateMainWindow(IMainController controller);
        IPackSimulatorView CreatePackSimulatorView(IPackSimulatorController controller);
    }
}
