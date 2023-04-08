using ShadowverseAnalyzer.Interfaces.Controllers;
using ShadowverseAnalyzer.Interfaces.Views;

namespace ShadowverseAnalyzer.WPF.Controllers
{
    internal class DeckAnalysisController : IDeckAnalysisController
    {
        private IDeckAnalysisView? View { get; set; }

        public void SetView(IDeckAnalysisView view)
        {
            View = view;
        }
    }
}
