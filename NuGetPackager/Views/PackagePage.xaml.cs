﻿using NuGetPackager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NuGetPackager.Views
{
    /// <summary>
    /// Interaction logic for PackagePage.xaml
    /// </summary>
    public partial class PackagePage : Page
    {
        public PackagePage(NuSpecViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel;
        }
    }
}
