using ShellDemoApp.Views;
using ShellDemoApp.Views.DeepPath;
using Xamarin.Forms;

namespace ShellDemoApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(Second), typeof(Second));
            Routing.RegisterRoute(nameof(Third), typeof(Third));
        }
    }
}
