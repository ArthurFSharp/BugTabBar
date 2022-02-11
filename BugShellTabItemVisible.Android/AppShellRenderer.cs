using Android.Content;
using BugShellTabItemVisible;
using BugShellTabItemVisible.Droid;
using Google.Android.Material.BottomNavigation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AppShell), typeof(AppShellRenderer))]
namespace BugShellTabItemVisible.Droid
{
    public class AppShellRenderer : ShellRenderer
    {
        public AppShellRenderer(Context context)
            : base(context)
        {
        }

        protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
        {
            return new AppTabBarAppearance(this, shellItem);
        }
    }

    public class AppTabBarAppearance : ShellBottomNavViewAppearanceTracker
    {
        public AppTabBarAppearance(IShellContext context, ShellItem shellItem)
            : base(context, shellItem)
        {
        }

        public override void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
        {
            bottomView.ItemIconSize = 100;
            bottomView.LabelVisibilityMode = LabelVisibilityMode.LabelVisibilityUnlabeled;
            bottomView.Elevation = 0f;
        }
    }
}
