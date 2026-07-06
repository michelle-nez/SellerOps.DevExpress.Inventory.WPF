using System.Windows;

using SellerOps.DevExpress.Inventory.Wpf.ViewModels;

namespace SellerOps.DevExpress.Inventory.Wpf;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}