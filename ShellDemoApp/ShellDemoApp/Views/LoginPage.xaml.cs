using ShellDemoApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellDemoApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}