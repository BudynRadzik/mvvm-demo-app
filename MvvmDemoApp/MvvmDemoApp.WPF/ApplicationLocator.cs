using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using MvvmDemoApp.Shared.BL.Classes;
using MvvmDemoApp.Shared.BL.Interfaces;
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
                    .AddSingleton<IUserAccountManager>(new UserAccountManager())
                    .BuildServiceProvider());
        }
        public static IUserAccountManager? UserAccountManager => Ioc.Default.GetRequiredService<IUserAccountManager>();
    }
}
