using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using NuGetPackager.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NuGetPackager.Services
{
    public class NavigationService : ObservableObject
    {
        private readonly IServiceProvider serviceProvider;
        private Page? _currentView;

        public Page? CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        public NavigationService(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void NavigateToPage<T>() where T : Page
        {
            CurrentView = serviceProvider.GetService<T>();
        }
    }
}
