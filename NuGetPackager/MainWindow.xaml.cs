using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using NuGetPackager.Services;
using NuGetPackager.ViewModels;
using NuGetPackager.Views;
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
using NavigationService = NuGetPackager.Services.NavigationService;

namespace NuGetPackager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private NavigationService? navigation;

        private PackagePage packagePage;
        private PushPage pushPage;

        public MainWindow()
        {
            InitializeComponent();
            packagePage = new PackagePage();
            pushPage = new PushPage();
        }

        public void Initialise(IServiceProvider serviceProvider)
        {
            packagePage.SetContext(new NuSpecViewModel(serviceProvider.GetRequiredService<NuGetService>()));

            navigation = serviceProvider.GetRequiredService<NavigationService>();

            DataContext = new MainViewModel(navigation,
                new RelayCommand(() => navigation.CurrentView = packagePage),
                new RelayCommand(() => navigation.CurrentView = pushPage));
        }
    }
}