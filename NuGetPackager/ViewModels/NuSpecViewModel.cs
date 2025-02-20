using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
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

        public IRelayCommand SelectFilesCommand { get; }

        public IRelayCommand RemoveSelectedFilesCommand { get; }

        public IReadOnlyCollection<string>? SelectedFiles { get; internal set; }

        public NuSpecViewModel(NuGetService service)
        {
            SubmitCommand = new AsyncRelayCommand(SubmitAsync);
            SelectFilesCommand = new RelayCommand(SelectFiles);
            RemoveSelectedFilesCommand = new RelayCommand(RemoveSelectedFiles);
            Model = new NuSpecModel();
        }

        private async Task SubmitAsync()
        {
            await Task.Delay(10);
        }

        private void SelectFiles()
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = true;

            if (dialog.ShowDialog() == true)
            {
                Model.Files.Clear();
                foreach (string fileName in dialog.FileNames)
                {
                    Model.Files.Add(fileName);
                }
            }
        }

        private void RemoveSelectedFiles()
        {
            if (SelectedFiles != null)
            {
                foreach (string fileName in SelectedFiles)
                {
                    Model.Files.Remove(fileName);
                }
                SelectedFiles = null;
            }
        }
    }
}
