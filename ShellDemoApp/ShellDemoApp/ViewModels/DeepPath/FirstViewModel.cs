using System.Windows.Input;
using Xamarin.Forms;

namespace ShellDemoApp.ViewModels.DeepPath
{
    public class FirstViewModel
    {
        public ICommand NextPageCommand { get; } = new Command(() => Shell.Current.GoToAsync("Second"));
        public ICommand LastPageCommand { get; } = new Command(() => Shell.Current.GoToAsync("Third"));
    }
}