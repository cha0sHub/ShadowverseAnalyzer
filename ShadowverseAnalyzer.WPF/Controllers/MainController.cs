using ShadowverseAnalyzer.Interfaces.Controllers;
using ShadowverseAnalyzer.Interfaces.Views;

namespace ShadowverseAnalyzer.WPF.Controllers
{
    internal class MainController : IMainController
    {

        private IMainWindow? Window { get; set; }

        private IDeckAnalysisController DeckAnalysisController { get; }
        private IDeckBuilderController DeckBuilderController { get; }
        private IDeckSelectorController DeckSelectorController { get; }
        private IPackSimulatorController PackSimulatorController { get; }
        private IViewFactory ViewFactory { get; }

        public MainController(IDeckAnalysisController deckAnalysisController, IDeckBuilderController deckBuilderController,
                              IDeckSelectorController deckSelectorController, IPackSimulatorController packSimulatorController,
                              IViewFactory viewFactory)
        {
            DeckAnalysisController = deckAnalysisController;
            DeckBuilderController = deckBuilderController;
            DeckSelectorController = deckSelectorController;
            PackSimulatorController = packSimulatorController;
            ViewFactory = viewFactory;
        }

        public void SetWindow(IMainWindow window)
        {
            Window = window;
        }

        public void DisplayDeckAnalysisView()
        {
            var deckAnalysisView = ViewFactory.CreateDeckAnalysisView(DeckAnalysisController);

            Window?.SetView(deckAnalysisView);
        }

        public void DisplayDeckBuilderView()
        {
            var deckBuilderView = ViewFactory.CreateDeckBuilderView(DeckBuilderController);

            Window?.SetView(deckBuilderView);
        }

        public void DisplayDeckSelectorView()
        {
            var deckSelectorView = ViewFactory.CreateDeckSelectorView(DeckSelectorController);

            Window?.SetView(deckSelectorView);
        }

        public void DisplayPackSimulatorView()
        {
            var packSimulatorView = ViewFactory.CreatePackSimulatorView(PackSimulatorController);

            Window?.SetView(packSimulatorView);
        }
    }
}
