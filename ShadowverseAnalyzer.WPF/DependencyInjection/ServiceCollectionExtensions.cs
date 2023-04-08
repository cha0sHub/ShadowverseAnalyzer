using Microsoft.Extensions.DependencyInjection;
using ShadowverseAnalyzer.Interfaces.Controllers;
using ShadowverseAnalyzer.Interfaces.Views;
using ShadowverseAnalyzer.WPF.Controllers;
using ShadowverseAnalyzer.WPF.Views;

namespace ShadowverseAnalyzer.WPF.DependencyInjection
{
    internal static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWpfServices(this IServiceCollection services)
        {
            services.AddTransient<IDeckAnalysisController, DeckAnalysisController>();
            services.AddTransient<IDeckBuilderController, DeckBuilderController>();
            services.AddTransient<IDeckSelectorController, DeckSelectorController>();
            services.AddTransient<IMainController, MainController>();
            services.AddTransient<IPackSimulatorController, PackSimulatorController>();
            services.AddTransient<IViewFactory, WpfViewFactory>();

            return services;
        }
    }
}
