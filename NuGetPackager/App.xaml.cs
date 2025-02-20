using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.Data;
using System.Windows;

namespace NuGetPackager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider serviceProvider;

        public App()
        {
            IServiceCollection services = new ServiceCollection();
            // services
            services.AddSingleton<Services.NuGetService>();
            services.AddSingleton<Services.NavigationService>();

            // view models
            services.AddSingleton<ViewModels.MainViewModel>();
            services.AddSingleton<ViewModels.NuSpecViewModel>();

            // views
            services.AddSingleton<MainWindow>();
            services.AddTransient<Views.PackagePage>();
            services.AddTransient<Views.PushPage>();

            serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MainWindow window = serviceProvider.GetRequiredService<MainWindow>();
            window.Show();
        }
    }
}
