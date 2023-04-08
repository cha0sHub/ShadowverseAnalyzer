using ShadowverseAnalyzer.Interfaces.Controllers;
using ShadowverseAnalyzer.Interfaces.Views;

namespace ShadowverseAnalyzer.WPF.Controllers
{
    internal class DeckSelectorController : IDeckSelectorController
    {

        private IDeckSelectorView? View { get; set; }

        public void SetView(IDeckSelectorView view)
        {
            View = view;
        }
    }
}
