using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.DependencyInjection;
using MvvmDemoApp.Shared.VM.ViewModels.Windows;

namespace MvvmDemoApp.Shared.VM
{
    public class ViewModelLocator
    {
        public static MainWindowVM? MainWindowViewModel
        {
            get
            {
                return Ioc.Default.GetService<MainWindowVM>();
            }
        }
    }
}
