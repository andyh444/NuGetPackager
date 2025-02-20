using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using NuGetPackager.Services;
using NuGetPackager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetPackager.ViewModels
{
    public class MainViewModel
    {
        public NavigationService Navigation { get; }
        public IRelayCommand NavigateToPackagePageCommand { get; }
        public IRelayCommand NavigateToPushPageCommand { get; }

        public MainViewModel(NavigationService navigation, IServiceProvider serviceProvider)
        {
            Navigation = navigation;
            NavigateToPackagePageCommand = new RelayCommand(() => Navigation.NavigateToPage<PackagePage>());
            NavigateToPushPageCommand = new RelayCommand(() => Navigation.NavigateToPage<PushPage>());

            Navigation.NavigateToPage<PackagePage>();
        }
    }
}
