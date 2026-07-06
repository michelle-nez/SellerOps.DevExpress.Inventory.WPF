using System.Configuration;
using System.Windows;
using DevExpress.Xpf.Core;

namespace SellerOps.DevExpress.Inventory.Wpf;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : System.Windows.Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        ApplicationThemeHelper.ApplicationThemeName = Theme.Office2019ColorfulName;
        base.OnStartup(e);
    }
}

