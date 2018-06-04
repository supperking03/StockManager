using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Windows;

using Caliburn.Micro;

using GUI.Properties;
using GUI.ViewModels;
using GUI.Views;

namespace GUI
{
    public class AppBootstrapper : BootstrapperBase
    {
        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<AppViewModel>();
        }
    }
}
