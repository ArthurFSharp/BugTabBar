using System;
using System.Collections.Generic;
using BugShellTabItemVisible.ViewModels;
using BugShellTabItemVisible.Views;
using Xamarin.Forms;

namespace BugShellTabItemVisible
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
