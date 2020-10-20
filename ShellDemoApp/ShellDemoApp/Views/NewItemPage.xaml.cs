using Xamarin.Forms;
using ShellDemoApp.Models;
using ShellDemoApp.ViewModels;

namespace ShellDemoApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}