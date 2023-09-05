using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using MvvmDemoApp.Shared.VM.ViewModels.Windows;

namespace MvvmDemoApp.WPF
{
    public static class ApplicationLocator
    {
        public static void RegisterDependencies()
        {
            Ioc.Default.ConfigureServices(
                new ServiceCollection()
                    .AddSingleton<MainWindowVM>()
                    .BuildServiceProvider());
        }
    }
}
