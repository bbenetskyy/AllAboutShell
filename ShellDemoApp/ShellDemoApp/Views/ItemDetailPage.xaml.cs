using System.ComponentModel;
using Xamarin.Forms;
using ShellDemoApp.ViewModels;

namespace ShellDemoApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}