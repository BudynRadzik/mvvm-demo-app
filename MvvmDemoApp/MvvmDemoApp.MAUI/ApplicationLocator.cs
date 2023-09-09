using MvvmDemoApp.Shared.BL.Classes;
using MvvmDemoApp.Shared.BL.Interfaces;
using MvvmDemoApp.Shared.VM.ViewModels.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDemoApp.MAUI
{
    public static class ApplicationLocator
    {
        public static MauiAppBuilder RegisterDependencies(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<MainPage>();
            mauiAppBuilder.Services.AddTransient<MainWindowVM>();
            mauiAppBuilder.Services.AddSingleton<IUserAccountManager>(new UserAccountManager());

            return mauiAppBuilder;
        }
    }
}
