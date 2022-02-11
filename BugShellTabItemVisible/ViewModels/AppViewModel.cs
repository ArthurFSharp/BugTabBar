using System;
using BugShellTabItemVisible.Views;
using Xamarin.Forms;

namespace BugShellTabItemVisible.ViewModels
{
    public class AppViewModel : BaseViewModel
    {
        private bool _isBrowseMenuVisible;

        public bool IsBrowseMenuVisible { get => _isBrowseMenuVisible; set => SetProperty(ref _isBrowseMenuVisible, value); }

        public AppViewModel()
        {
            IsBrowseMenuVisible = true;

            MessagingCenter.Subscribe<AboutPage, bool>(this, "browse", (sender, arg) =>
            {
                IsBrowseMenuVisible = arg;
            });
        }
    }
}
