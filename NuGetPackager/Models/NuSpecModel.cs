using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGetPackager.Models
{
    public class NuSpecModel : ObservableObject
    {
        private string id = "blah";
        private string version = string.Empty;
        private string authors = string.Empty;
        private string owners = string.Empty;
        private string description = string.Empty;
        private string license = string.Empty;
        private string requireLicenseAcceptance = string.Empty;

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
    }
}
