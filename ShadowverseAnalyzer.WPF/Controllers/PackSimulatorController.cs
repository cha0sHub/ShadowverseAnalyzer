using ShadowverseAnalyzer.Interfaces.Controllers;
using ShadowverseAnalyzer.Interfaces.Views;

namespace ShadowverseAnalyzer.WPF.Controllers
{
    internal class PackSimulatorController : IPackSimulatorController
    {

        private IPackSimulatorView? View { get; set; }

        public void SetView(IPackSimulatorView view)
        {
            View = view;
        }
    }
}
