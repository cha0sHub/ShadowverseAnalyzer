using ShadowverseAnalyzer.Interfaces.Controllers;
using ShadowverseAnalyzer.Interfaces.Views;

namespace ShadowverseAnalyzer.WPF.Controllers
{
    internal class DeckBuilderController : IDeckBuilderController
    {

        private IDeckBuilderView? View { get; set; }

        public void SetView(IDeckBuilderView view)
        {
            View = view;
        }
    }
}
