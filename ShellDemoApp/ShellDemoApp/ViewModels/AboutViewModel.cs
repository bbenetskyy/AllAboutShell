using System.Windows.Input;
using ShellDemoApp.Views;
using ShellDemoApp.Views.DeepTabs;
using Xamarin.Forms;

namespace ShellDemoApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            LogOutCommand = new Command( () => Shell.Current.GoToAsync($"//{nameof(LoginPage)}"));
            ShowFlyoutCommand = new Command(() => Shell.Current.GoToAsync($"//{nameof(TabOne)}"));
        }

        public ICommand LogOutCommand { get; }
        public ICommand ShowFlyoutCommand { get; }
    }
}