using Microsoft.Extensions.DependencyInjection;
using NuGetPackager.Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NuGetPackager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Initialise(IServiceProvider serviceProvider)
        {
            NuGetService service = serviceProvider.GetRequiredService<NuGetService>();
            nuSpecFormView.DataContext = new ViewModels.NuSpecViewModel(service);
        }
    }
}