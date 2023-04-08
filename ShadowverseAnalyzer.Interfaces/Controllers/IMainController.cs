using ShadowverseAnalyzer.Interfaces.Views;

namespace ShadowverseAnalyzer.Interfaces.Controllers
{
    public interface IMainController
    {
        void SetWindow(IMainWindow window);
        void DisplayDeckAnalysisView();
        void DisplayDeckBuilderView();
        void DisplayDeckSelectorView();
        void DisplayPackSimulatorView();
    }
}
