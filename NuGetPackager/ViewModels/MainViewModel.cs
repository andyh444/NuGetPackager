using CommunityToolkit.Mvvm.Input;
using NuGetPackager.Services;
using NuGetPackager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetPackager.ViewModels
{
    internal class MainViewModel
    {
        public NavigationService Navigation { get; }
        public IRelayCommand NavigateToPackagePageCommand { get; }
        public IRelayCommand NavigateToPushPageCommand { get; }

        public MainViewModel(NavigationService navigation, IRelayCommand navigateToPackagePageCommand, IRelayCommand navigateToPushPageCommand)
        {
            NavigateToPackagePageCommand = navigateToPackagePageCommand;
            NavigateToPushPageCommand = navigateToPushPageCommand;
            Navigation = navigation;

            NavigateToPackagePageCommand.Execute(null);
        }
    }
}
