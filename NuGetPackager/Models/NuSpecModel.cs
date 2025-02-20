using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetPackager.Models
{
    public class NuSpecModel : ObservableObject
    {
        public IReadOnlyList<string> Frameworks { get; } = ["net48", "netstandard2.0", "netstandard2.1"];

        private string id = string.Empty;
        private string version = string.Empty;
        private string authors = string.Empty;
        private string owners = string.Empty;
        private string description = string.Empty;
        private string license = string.Empty;
        private string requireLicenseAcceptance = string.Empty;
        private string selectedFramework = string.Empty;

        public string Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string Version
        {
            get => version;
            set
            {
                version = value;
                OnPropertyChanged(nameof(Version));
            }
        }

        
        public string Authors
        {
            get => authors;
            set
            {
                authors = value;
                OnPropertyChanged(nameof(Authors));
            }
        }

        
        public string Owners
        {
            get => owners;
            set
            {
                owners = value;
                OnPropertyChanged(nameof(Owners));
            }
        }

        
        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        
        public string License
        {
            get => license;
            set
            {
                license = value;
                OnPropertyChanged(nameof(License));
            }
        }

        public string RequireLicenseAcceptance
        {
            get => requireLicenseAcceptance;
            set
            {
                requireLicenseAcceptance = value;
                OnPropertyChanged(nameof(RequireLicenseAcceptance));
            }
        }

        public string SelectedFramework
        {
            get => selectedFramework;
            set
            {
                selectedFramework = value;
                OnPropertyChanged(nameof(SelectedFramework));
            }
        }

        public ObservableCollection<string> Files { get; } = new ObservableCollection<string>();
    }
}
