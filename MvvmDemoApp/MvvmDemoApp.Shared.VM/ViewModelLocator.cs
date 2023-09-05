﻿using CommunityToolkit.Mvvm.DependencyInjection;
using MvvmDemoApp.Shared.VM.ViewModels.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDemoApp.Shared.VM
{
    public class ViewModelLocator
    {
        public static MainWindowVM? MainWindowViewModel => Ioc.Default.GetService<MainWindowVM>();
    }
}
