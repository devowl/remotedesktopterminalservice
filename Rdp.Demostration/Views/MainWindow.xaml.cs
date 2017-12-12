using System.Windows;

using Rdp.Demostration.ViewModels;

namespace Rdp.Demostration.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor <see cref="MainWindow"/>.
        /// </summary>
        public MainWindow()
        {
            DataContext = new MainWindowViewModel();
            InitializeComponent();
        }
    }
}