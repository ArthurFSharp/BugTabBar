using System.ComponentModel;
using Xamarin.Forms;
using BugShellTabItemVisible.ViewModels;

namespace BugShellTabItemVisible.Views
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
