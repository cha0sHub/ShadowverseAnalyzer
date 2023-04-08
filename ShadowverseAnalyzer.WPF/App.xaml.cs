using Microsoft.Extensions.DependencyInjection;
using ShadowverseAnalyzer.Interfaces.Controllers;
using ShadowverseAnalyzer.Interfaces.Views;
using ShadowverseAnalyzer.WPF.DependencyInjection;
using System.Windows;

namespace ShadowverseAnalyzer.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfServices();
            var serviceProvider = serviceCollection.BuildServiceProvider();

            var mainController = serviceProvider.GetRequiredService<IMainController>();
            var viewFactory = serviceProvider.GetRequiredService<IViewFactory>();

            var mainWindow = viewFactory.CreateMainWindow(mainController);

            mainController.DisplayDeckSelectorView();

            mainWindow.ShowWindow();
        }
    }
}
