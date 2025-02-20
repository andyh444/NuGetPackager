using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NuGetPackager.Models;
using NuGetPackager.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetPackager.ViewModels
{
    public class NuSpecViewModel : ObservableObject
    {
        public NuSpecModel Model { get; }

        public IAsyncRelayCommand SubmitCommand { get; }

        public NuSpecViewModel(NuGetService service)
        {
            SubmitCommand = new AsyncRelayCommand(SubmitAsync);
            Model = new NuSpecModel();
        }

        private async Task SubmitAsync()
        {
            await Task.Delay(10);
        }
    }
}
