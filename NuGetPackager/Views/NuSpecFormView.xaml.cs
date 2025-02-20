using NuGetPackager.ViewModels;
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
    /// Interaction logic for NuSpecForm.xaml
    /// </summary>
    public partial class NuSpecFormView : UserControl
    {
        public NuSpecFormView()
        {
            InitializeComponent();
            filesListBox.SelectionChanged += FilesListBox_SelectionChanged;
        }

        private void FilesListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is NuSpecViewModel viewModel)
            {
                // SelectedItems is not bindable, so just do this workaround
                viewModel.SelectedFiles = filesListBox.SelectedItems.Cast<string>().ToList();
            }
        }
    }
}
