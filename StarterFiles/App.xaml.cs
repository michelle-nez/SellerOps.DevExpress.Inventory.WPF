using System.Windows;
using DevExpress.Xpf.Core;

namespace SellerOps.DevExpress.Inventory.Wpf;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        ApplicationThemeHelper.ApplicationThemeName = Theme.Office2019ColorfulName;
        base.OnStartup(e);
    }
}
